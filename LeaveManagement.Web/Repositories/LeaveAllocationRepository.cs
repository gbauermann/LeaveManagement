using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;

        public LeaveAllocationRepository(ApplicationDbContext context,
            UserManager<Employee> userManager,
            ILeaveTypeRepository LeaveTypeRepository,
            IMapper mapper) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            leaveTypeRepository = LeaveTypeRepository;
            this.mapper = mapper;
        }

        public async Task<bool> AllocationExists(string emplyeeId, int leaveTypeId, int period)
        {
            return await context.LeaveAllocations.AnyAsync(a => a.EmployeeId == emplyeeId
                                                                && a.LeaveTypeId == leaveTypeId
                                                                && a.Period == period);
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            var allocations = await context.LeaveAllocations
                .Include(a => a.LeaveType)
                .Where(l => l.EmployeeId == employeeId)
                .ToListAsync();

            var employee = await userManager.FindByIdAsync(employeeId);

            var emplyeeAllocationModel = mapper.Map<EmployeeAllocationVM>(employee);
            emplyeeAllocationModel.LeaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);

            return emplyeeAllocationModel;
        }

        public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int alocationId)
        {
            var allocation = await context.LeaveAllocations
                .Include(a => a.LeaveType)
                .FirstOrDefaultAsync(l => l.Id == alocationId);

            if (allocation == null) return null;

            var employee = await userManager.FindByIdAsync(allocation.EmployeeId);

            var model = mapper.Map<LeaveAllocationEditVM>(allocation);
            model.Employee = mapper.Map<EmployeeAllocationVM>(employee);

            return model;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var emplyees = await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocation>();

            foreach (var emplyee in emplyees)
            {
                if (await AllocationExists(emplyee.Id, leaveTypeId, period))
                    continue;

                var allocation = new LeaveAllocation
                {
                    EmployeeId = emplyee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType?.DefaultDays ?? 0
                };

                allocations.Add(allocation);
            }

            await AddRangeAsync(allocations);
        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationVM model)
        {
            var leaveAllocation = await GetAsync(model.Id);
            if (leaveAllocation == null) return false;

            leaveAllocation.Period = model.Period;
            leaveAllocation.NumberOfDays = model.NumberOfDays;
            await UpdateAsync(leaveAllocation);
            return true;
        }
    }
}
