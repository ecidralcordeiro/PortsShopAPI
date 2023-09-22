using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortsShop.Domain.Models;

public class Price
{

    public int Id { get; set; }
    public double CurrentPrice { get; set; }
    public double OldPrice { get; set; }
    public DateTime DateUpdatePrice {  get; set; }
}
