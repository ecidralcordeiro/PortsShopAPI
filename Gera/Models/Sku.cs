using System;
using System.Collections.Generic;

namespace GeraClasse.Models;

public partial class Sku
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int IdPrice { get; set; }

    public int IdStock { get; set; }

    public double Weigth { get; set; }

    public double Heigth { get; set; }

    public double Width { get; set; }

    public string Color { get; set; } = null!;

    public string Size { get; set; } = null!;

    public string Barcode { get; set; } = null!;

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Price? Price { get; set; }

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();

    public virtual Stock? Stock { get; set; }
}
