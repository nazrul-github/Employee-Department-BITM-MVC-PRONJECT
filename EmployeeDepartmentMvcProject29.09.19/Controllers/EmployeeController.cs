using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeDepartmentMvcProject29._09._19.BLL;
using EmployeeDepartmentMvcProject29._09._19.Models;
using EmployeeDepartmentMvcProject29._09._19.ViewModels;

namespace EmployeeDepartmentMvcProject29._09._19.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeManager employeeManager = new EmployeeManager();
        DepartmentManager departmentManager = new DepartmentManager();
        EmployeeDepartmentViewModel employeeDepartmentView = new EmployeeDepartmentViewModel();

        // GET: Employee
        public ActionResult Index()
        {
            employeeDepartmentView.Departments = departmentManager.GetAllDepartments();
            employeeDepartmentView.Employees = employeeManager.GetAllEmployee();

            return View(employeeDepartmentView);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Department = departmentManager.GetAllDepartments();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            bool isSaved = employeeManager.SaveEmployee(employee);
            if (isSaved)
            {
                return RedirectToAction("Index");
            }

            ViewBag.NidExist = true;
            ViewBag.Department = departmentManager.GetAllDepartments();
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Employee employee = employeeManager.GetAllEmployee().Find(e => e.EmployeeId == id);
            ViewBag.Department = departmentManager.GetAllDepartments();
            ViewBag.NidExist2 = false;
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            bool isUpdated = employeeManager.UpdateEmployee(employee);
            if (isUpdated)
            {
                return RedirectToAction("Index");
            }

            ViewBag.NidExist2 = true;
            ViewBag.Department = departmentManager.GetAllDepartments();
            return View(employee);
        }
      /*  [HttpGet]
        public ActionResult Delete(int id)
        {
             Employee employee = employeeManager.GetAllEmployee().Single(e => e.EmployeeId == id);
            bool isDeleted = employeeManager.DeleteEmployee(employee);
           ViewBag.Department = departmentManager.GetAllDepartments()
                .Single(d => d.DepartmentId == employee.DepartmentId);
            return RedirectToAction("Index");
        }*/
      

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Employee employee = employeeManager.GetAllEmployee().Single(e => e.EmployeeId == id);
            bool isDeleted = employeeManager.DeleteEmployee(employee);
            return RedirectToAction("Index");
        }
    }
}