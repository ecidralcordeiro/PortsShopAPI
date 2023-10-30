using System;
using System.Collections.Generic;

namespace GeraClasse.Models;

public partial class Address
{
    public int Id { get; set; }

    public string Country { get; set; } = null!;

    public string State { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Region { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string Street { get; set; } = null!;

    public virtual User Id1 { get; set; } = null!;

    public virtual Store IdNavigation { get; set; } = null!;
}
