using System;
using System.Collections.Generic;

namespace GeraClasse.Models;

public partial class Store
{
    public int Id { get; set; }

    public string? CompanyName { get; set; }

    public string? FantasyName { get; set; }

    public string? Cnpj { get; set; }

    public int IdUser { get; set; }

    public int IdAdress { get; set; }

    public int UserId { get; set; }

    public virtual Address? Address { get; set; }

    public virtual Product IdNavigation { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
