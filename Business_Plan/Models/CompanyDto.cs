using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business_Plan.Models
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //fk
        //  public ProductDto ProductID { get; set; }
    }
}