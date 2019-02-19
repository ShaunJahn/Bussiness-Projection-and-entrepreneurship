using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business_Plan.ViewModels;
using Business_Plan.Models;


//Home page is login area
//Email password, 2 step verification
//Down the line purchase options
namespace Business_Plan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            new TempDto();
            return View();

        }


        [HttpPost]
        public IActionResult InputDetails(DummyLoginViewModel dummyLogin)
        {
            TempDto.Name = dummyLogin.Name;
            TempDto.Surname = dummyLogin.Surname;
            TempDto.CompanyName = dummyLogin.CompanyName;
            return RedirectToAction("Index", "DashBoard");
        }

    }
}