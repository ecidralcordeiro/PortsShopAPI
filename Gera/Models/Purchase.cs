using System;
using System.Collections.Generic;

namespace GeraClasse.Models;

public partial class Purchase
{
    public int Id { get; set; }

    public double TotalPrice { get; set; }

    public DateTime Date { get; set; }

    public int IdSku { get; set; }

    public int IdUser { get; set; }

    public string? IdPaymentType { get; set; }

    public virtual PaymentType IdNavigation { get; set; } = null!;

    public virtual Sku IdSkuNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
