using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business_Plan.Models
{
    public class ProdutBasicsUnitCostsDto
    {
        public int Id { get; set; }
        //fk
        public ProductDto Product { get; set; }
        public string Month { get; set; }
        public double UnitCostNoVat { get; set; }
        public double UnitCostWithVat { get; set; }
        public double UnitSellNoVat { get; set; }
        public double UnitSellWithVat { get; set; } //user input
        public double MarginPercentage { get; set; }
        public double MaringRands { get; set; }
    }
}
