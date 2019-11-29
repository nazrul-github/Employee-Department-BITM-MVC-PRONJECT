using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDepartmentMvcProject29._09._19.Models;

namespace EmployeeDepartmentMvcProject29._09._19.ViewModels
{
    public class EmployeeDepartmentViewModel
    {
       /* public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NID { get; set; }
        public DateTime JoiningDate { get; set; }
        public int DepartmentId { get; set; }
        public string BloodGroup { get; set; }

        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }*/

       public List<Employee> Employees { get; set; }
       public List<Department> Departments { get; set; }
       
       public EmployeeDepartmentViewModel()
       {
           Employees = new List<Employee>();
           Departments = new List<Department>();
       }
    }
}