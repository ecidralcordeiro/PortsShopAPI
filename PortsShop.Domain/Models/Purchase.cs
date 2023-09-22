using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortsShop.Domain.Models;

public class Purchase
{
    public int Id { get; set; } 
    public double TotalPrice { get; set; }
    public DateTime DATE { get; set; }
    public int IdSKU { get; set; }
    public int IdUser { get; set; }
    public string? IdPaymentType { get; set; }
    public User User { get; set; }
    public SKU SKU { get; set; }
    public PaymentType? PaymentType { get; set; }

}
