using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XgearFinal.Models
{
    internal interface Order
    {
        [Key]
        int OrderId { get; set; }
        int OrderUserId { get; set; }
        int OrderProductId { get; set; }
        int OrderQuantity { get; set; }
        int OrderTotal { get; set; }
        string OrderStatus { get; set; }
        string OrderDate { get; set; }
        //relationships
        
    }
}
