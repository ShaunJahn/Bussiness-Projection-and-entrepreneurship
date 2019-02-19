using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Business_Plan.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public CompanyDto Company { get; set; }
        public string ProductName { get; set; }
    }
}
