using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business_Plan.ViewModels;
using Business_Plan.Models;

namespace Business_Plan.Controllers
{
    public class ProductInputController : Controller
    {
        public IActionResult Index()
        {
            var ProductUnit = new InputProductUnitViewModel();
            return View(ProductUnit);
        }

        [HttpGet]
        public IActionResult getProductUnits(InputProductUnitViewModel inputProductUnitViewModel)
        {
            TempDto.produtBasicsUnitCosts.Append(inputProductUnitViewModel.ProdutBasicsUnitCosts);
            return RedirectToAction("Index");
        }
    }
}