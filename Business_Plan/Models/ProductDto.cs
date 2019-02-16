using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business_Plan.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public CompanyDto Company { get; set; }

        public string ProductName { get; set; }

        public virtual List<FOBDto> FOBCalculation { get; set; }
        public virtual StockDto Stock { get; set; }
        public virtual ProdutBasicsUnitCostsDto ProdutBasicsUnitCosts { get; set; }
        public virtual TotalCostOfProductDto TotalCostOfProcust { get; set; }
    }
}
