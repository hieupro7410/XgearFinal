using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XgearFinal.Models
{
    public class Brand
    {
        [Key]
        int BrandId { get; set; }
        string BrandName { get; set; }
        string BrandDescription { get; set; }
        //relationships
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        
    }
}
