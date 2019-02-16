using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

//build a product with user information

namespace Business_Plan.Controllers
{
    public class ProductUnitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}