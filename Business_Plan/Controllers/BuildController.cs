using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business_Plan.ViewModels;

//Build starting :
//Get company, user and how many products

namespace Business_Plan.Controllers
{
    public class BuildController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }


    }
}