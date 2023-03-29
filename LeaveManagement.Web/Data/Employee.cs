﻿using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.Data
{
    public class Employee: IdentityUser
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string TaxId { get; set; }
        public int MyProperty { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
