using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortsShop.Domain.Models;

public class Cart
{
    public int Id { get; set; }
    public int IdUser { get; set; }
    public int IdSku { get; set; }
    public User User { get; set; }
    public SKU SKU { get; set; }
}