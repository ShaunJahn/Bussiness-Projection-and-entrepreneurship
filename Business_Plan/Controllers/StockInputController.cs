﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business_Plan.ViewModels;
using Business_Plan.Models;

namespace Business_Plan.Controllers
{
    public class StockInputController : Controller
    {
        public IActionResult Index()
        {
            var stock = new InputStockViewModel();
            return View(stock);
        }

        [HttpPost]
        public IActionResult GetStock(InputStockViewModel inputStock)
        {

            for (int k = 0; k < 5; k++)
                TempDto.StockList.Append(inputStock.Stock);
            return RedirectToAction("index", "Build");
        }
    }
}