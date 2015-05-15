using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwitterBootstrapMVCDemo.Models;

namespace TwitterBootstrapMVCDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var testViewModel = new TestModel
            {
                Amount = 95.00d,
                Description = "This is test description",
                Email = "Ketan.K.Deshmukh@gmail.com",
                Gender = "Male",
                Password = "Test",
                RememberMe = true,
                UserName = "Ketan Deshmukh"
            };
            return View(testViewModel);
        }


    }
}