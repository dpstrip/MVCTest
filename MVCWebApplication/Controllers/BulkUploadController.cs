using MVCWebApplication.Filters;
using MVCWebApplication.Models;
using MVCWebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplication.Controllers
{
    public class BulkUploadController : Controller
    {
        // GET: BulkUpload
        [HeaderFooterFilter]
        [AdminFilters]
        public ActionResult Index()
        {
            return View(new FileUploadViewModel());
        }


        [AdminFilters]
        public ActionResult Upload(FileUploadViewModel model)
        {
            List<Employee> employees = GetEmployees(model);
            EmployeeBusinessLayer bal = new EmployeeBusinessLayer();
            bal.UploadEmployees(employees);
            return RedirectToAction("Index", "Employee");
        }

        private List<Employee> GetEmployees(FileUploadViewModel model)
        {
            List<Employee> employees = new List<Employee>();
            StreamReader csvreader = new StreamReader(model.fileUpload.InputStream);
            csvreader.ReadLine();
            while(!csvreader.EndOfStream)
            {
                var line = csvreader.ReadLine();
                var values = line.Split(',');
                Employee e = new Employee();
                e.FirstName = values[0];
                e.LastName = values[1];
                e.Salary = int.Parse(values[2]);
                employees.Add(e);
            }
            return employees;
        }
    }
}