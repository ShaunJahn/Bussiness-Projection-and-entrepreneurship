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
            var DashBoard = new DashboardViewModel()
            {
                ProductDashBoardView = new ProductDashBoardViewModel()
                {
                    ProductName = "Name Here",
                    Stock = TempDto.StockList,
                    FOBCalculation = TempDto.SingleFob,
                    ProdutBasicsUnitCosts = TempDto.ProdutBasicsUnitCosts,
                    TotalCostOfProcust = TempDto.TotalCostOfProduct
                }
            };

            return View();
        }
    }
}