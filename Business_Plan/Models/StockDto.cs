using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business_Plan.Models
{
    public class StockDto
    {
        public int Id { get; set; }
        //fk
        public List<ProductDto> Product { get; set; }
        public string Month { get; set; }
        public int UnitOpeningStock { get; set; }
        public int UnitPurshases { get; set; } //user input
        public int UnitSales { get; set; } // user input
        public int UnitClosingStock { get; set; }
        public int WeeksForward { get; set; }
        public int OverUnderStock { get; set; }
    }
}
