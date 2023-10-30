using System;
using System.Collections.Generic;

namespace GeraClasse.Models;

public partial class PaymentType
{
    public int Id { get; set; }

    public string Number { get; set; } = null!;

    public string Type { get; set; } = null!;

    public DateTime Expiration { get; set; }

    public int SecurityCode { get; set; }

    public virtual Purchase? Purchase { get; set; }
}
