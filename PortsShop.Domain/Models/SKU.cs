using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortsShop.Domain.Models;

public class SKU
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int IdPrice { get; set; }
    public int IdStock { get; set; }
    public Price Price { get; set; }
    public Stock Stock { get; set; }
    public double Weigth { get; set; }
    public double Heigth {  get; set; }
    public double Width { get; set; }
    public string Color { get ; set; }
    public string Size {  get; set; }
    public string Barcode { get; set; }
    public ICollection<Cart> Carts { get; set; }
    public ICollection<Purchase> Purchases { get; set; }


}
