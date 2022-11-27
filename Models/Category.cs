using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XgearFinal.Models
{
    public class Category
    {
        [Key]
        int CategoryId { get; set; }
        string CategoryName { get; set; }
        string CategoryDescription { get; set; }
        //relationships
        public List<Brand> Brands { get; set; }
        public List<Product> Products { get; set; }


    }
}
