﻿using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
        Task<bool> AllocationExists(string emplyeeId, int leaveTypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int alocationId);
        Task<bool> UpdateEmployeeAllocation(LeaveAllocationVM leaveAllocation);
    }
}