using System;
using System.Collections.Generic;

namespace GeraClasse.Models;

public partial class Price
{
    public int Id { get; set; }

    public double CurrentPrice { get; set; }

    public double OldPrice { get; set; }

    public DateTime DateUpdatePrice { get; set; }

    public virtual Sku IdNavigation { get; set; } = null!;
}
