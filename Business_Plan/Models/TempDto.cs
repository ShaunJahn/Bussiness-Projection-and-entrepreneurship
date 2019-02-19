using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business_Plan.Models
{
    public class TempDto
    {
        public static string Name { get; set; }
        public static string Surname { get; set; }
        public static string CompanyName { get; set; }
        public static FOBDto SingleFob { get; set; }
        public static IEnumerable<StockDto> StockList { get; set; }
        public static IEnumerable<ProdutBasicsUnitCostsDto> ProdutBasicsUnitCosts { get; set; }
        public static IEnumerable<TotalCostOfProductDto> TotalCostOfProduct { get; set; }
    }
}
