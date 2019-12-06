using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDepartmentMvcProject29._09._19.DAL;
using EmployeeDepartmentMvcProject29._09._19.Models;

namespace EmployeeDepartmentMvcProject29._09._19.BLL
{
    public class EmployeeManager
    {
        EmployeeGateway employeeGateway = new EmployeeGateway();


        public List<Employee> GetAllEmployee()
        {
            return employeeGateway.GetAllEmployees();
        }

        public bool SaveEmployee(Employee employee)
        {
            if (IsNidExist(employee))
            {
                return false;
            }

            return employeeGateway.SaveEmployee(employee);
        }

        public bool UpdateEmployee(Employee employee)
        {
            if (IsNidExist(employee))
            {
                return false;
            }

            return employeeGateway.UpdateEmployee(employee);
        }

        public bool DeleteEmployee(Employee employee)
        {
           bool isDeleted = employeeGateway.DeleteEmployee(employee);
           return isDeleted;
        }

        public bool IsNidExist(Employee employee)
        {
            if (employee.EmployeeId!=0)
            {
                Employee aEmployee = employeeGateway.GetAllEmployees().Single(e => e.EmployeeId == employee.EmployeeId);
                bool isNIDForCurrentEmploye = employeeGateway.GetAllEmployees().Any(e => e.NID == employee.NID && e.NID != aEmployee.NID);
                return isNIDForCurrentEmploye;
            }
            bool isExist =  employeeGateway.GetAllEmployees().Any(e => e.NID == employee.NID);
            return isExist;
        }
    }
}