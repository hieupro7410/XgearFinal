using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XgearFinal.Models
{
    public class Product
    {
        int ProductId { get; set; }
        string ProductName { get; set; }
        string ProductDescription { get; set; }
        int ProductPrice { get; set; }
        int ProductQuantity { get; set; }
        string ProductImage { get; set; }
        int ProductCategoryId { get; set; }
        int ProductBrandId { get; set; }
    }
}
