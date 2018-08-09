﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return View("MyView");
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