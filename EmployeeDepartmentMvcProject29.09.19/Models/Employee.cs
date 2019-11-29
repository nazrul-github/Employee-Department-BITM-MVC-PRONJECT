using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDepartmentMvcProject29._09._19.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string NID { get; set; }
        public DateTime JoiningDate { get; set; }
        public string DepartmentId { get; set; }
        public string BloodGroup { get; set; }

        public Department Department { get; set; }
    }
}