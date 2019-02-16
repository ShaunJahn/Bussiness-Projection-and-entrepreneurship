using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business_Plan.Models
{
    public class TotalCostOfProductDto
    {
        public int Id { get; set; }

        //fk
        public List<ProductDto> Product { get; set; }
        public List<ProdutBasicsUnitCostsDto> UnitInfo { get; set; }

        public string Month { get; set; }
        public double PurchasesRandsNoVat { get; set; }
        public double SalesCostRandsNoVat { get; set; }
        public double SalesSellingRandsNoVar { get; set; }
        public double MarginRands { get; set; }
        public double StockOnHandNoVat { get; set; }
    }
}
