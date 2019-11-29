using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDepartmentMvcProject29._09._19.DAL;
using EmployeeDepartmentMvcProject29._09._19.Models;

namespace EmployeeDepartmentMvcProject29._09._19.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway departmentGateway = new DepartmentGateway();

        public List<Department> GetAllDepartments()
        {
            return departmentGateway.GetAllDepartments();
        }
    }
}