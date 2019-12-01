using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeDepartmentMvcProject29._09._19.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        public string Name { get; set; }
        public string Designation { get; set; }
        public string NID { get; set; }
        [DataType(DataType.Date,ErrorMessage = "Please enter a valid date")]
        public DateTime JoiningDate { get; set; }
        public int DepartmentId { get; set; }
        public string BloodGroup { get; set; }

        public Department Department { get; set; }
    }
}