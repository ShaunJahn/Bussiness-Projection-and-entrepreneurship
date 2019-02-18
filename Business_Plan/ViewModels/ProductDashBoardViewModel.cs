using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Plan.Models;

namespace Business_Plan.ViewModels
{
    public class ProductDashBoardViewModel
    {
        public string ProductName { get; set; }

        public virtual FOBDto FOBCalculation { get; set; }
        public virtual IEnumerable<StockDto> Stock { get; set; }
        public virtual IEnumerable<ProdutBasicsUnitCostsDto> ProdutBasicsUnitCosts { get; set; }
        public virtual IEnumerable<TotalCostOfProductDto> TotalCostOfProcust { get; set; }
    }
}
