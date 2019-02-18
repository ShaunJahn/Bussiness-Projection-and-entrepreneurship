using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business_Plan.ViewModels;
using Business_Plan.Models;
using Business_Plan.Calculations;

//Build starting :
//buld stock product and fob after total costs

namespace Business_Plan.Controllers
{
    public class BuildController : Controller
    {
        private Calculation _calc;

        public BuildController(Calculation calculation)
        {
            _calc = calculation;
        }
        public IActionResult Index()
        {

            return View();
        }

        public void BuildStock()
        {
            TempDto.StockList = _calc.CalcStock(TempDto.StockList);
        }

        public void BuildProductUnit()
        {
            TempDto.ProdutBasicsUnitCosts = _calc.ProductUnitCosts(TempDto.ProdutBasicsUnitCosts);
        }

        public void BuildFob()
        {
            TempDto.SingleFob = _calc.CalcFob(_calc.CalcFob(TempDto.SingleFob));
        }

        public void BuildTotals()
        {
            TempDto.TotalCostOfProduct = _calc.TotalCostOfProducts(TempDto.StockList, TempDto.ProdutBasicsUnitCosts);
        }

    }
}