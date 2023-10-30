using System;
using System.Collections.Generic;

namespace GeraClasse.Models;

public partial class Stock
{
    public int Id { get; set; }

    public double Stock1 { get; set; }

    public string? TypeStock { get; set; }

    public virtual Sku IdNavigation { get; set; } = null!;
}
