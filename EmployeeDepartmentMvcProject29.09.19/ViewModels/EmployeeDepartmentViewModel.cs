using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDepartmentMvcProject29._09._19.ViewModels
{
    public class EmployeeDepartmentViewModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NID { get; set; }
        public DateTime JoiningDate { get; set; }
        public string DepartmentId { get; set; }
        public string BloodGroup { get; set; }

        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
    }
}