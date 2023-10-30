using System;
using System.Collections.Generic;

namespace GeraClasse.Models;

public partial class Person
{
    public int Id { get; set; }

    public DateTime Birthday { get; set; }

    public string? Cpf { get; set; }

    public string? Identity { get; set; }

    public string? Passport { get; set; }

    public virtual User IdNavigation { get; set; } = null!;
}
