using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Plan.Models;
using Business_Plan.ViewModels;
using Microsoft.AspNetCore.Mvc;

//gets input for fob

namespace Business_Plan.Controllers
{
    public class FOBController : Controller
    {
        public IActionResult Index()
        {
            var Fob = new InputFobViewModel();
            return View(Fob);
        }

        [HttpPost]
        public IActionResult getInputFob(InputFobViewModel inputFob)
        {
            TempDto.SingleFob = inputFob.FOBDto;
            return RedirectToAction("index");
        }
    }
}