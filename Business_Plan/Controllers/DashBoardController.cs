using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business_Plan.Models;
using Business_Plan.ViewModels;

//Display Panel

namespace Business_Plan.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var userInfo = new DashboardViewModel()
            {
                userInformation = new UserInformation()
                {
                    Name = TempDto.Name,
                    Surname = TempDto.Surname,
                    CompanyName = TempDto.CompanyName
                }
            };
            return View(userInfo);
        }
    }
}