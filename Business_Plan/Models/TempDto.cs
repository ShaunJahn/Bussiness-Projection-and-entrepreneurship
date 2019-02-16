using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business_Plan.Models
{
    public class TempDto
    {
        public static FOBDto SingleFob { get; set; }
        public static IEnumerable<StockDto> StockList { get; set; }
        public static IEnumerable<ProdutBasicsUnitCostsDto> produtBasicsUnitCosts { get; set; }
    }
}
