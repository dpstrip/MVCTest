using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebApplication.Models;
using MVCWebApplication.ViewModels;

namespace MVCWebApplication.Controllers
{
    public class TestController : Controller
    {
        public string GetString()
        {
            return "Hello World is old now.  Its time for Wassup bro;)";
        }

        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "Customer 1";
            c.Address = "Address 1";

            return c;
        }

        public ActionResult GetView()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<Employee> employees = empBal.GetEmployees();
            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach(Employee emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                empViewModel.Salary = emp.Salary.ToString("C");
                if(emp.Salary> 15000)
                {
                    empViewModel.SalaryColor = "yellow";
                }
                else
                {
                    empViewModel.SalaryColor = "green";
                }
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.UserName = "Admin";
            employeeListViewModel.Employees = empViewModels;
            return View("MyView", employeeListViewModel);
        }

    }

    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return this.CustomerName + " | " + this.Address;
        }
    }
}