using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business_Plan.Models
{
    public class FOBDto
    {
        //pk
        public int Id { get; set; }
        //fk
        public ProductDto Product { get; set; }

        public double FobOfProduct { get; set; }  //user input
        public double CurrentExchangeRate { get; set; }
        public double TotalRandsFOB { get; set; }
        public double ShippingCost { get; set; } //user input
        public double Duty { get; set; } //user input
        public double ApplicationFee { get; set; } //user input
        public double LandedCost { get; set; }
        public double Vat { get; set; }
        public double LandedVat { get; set; }
    }
}
