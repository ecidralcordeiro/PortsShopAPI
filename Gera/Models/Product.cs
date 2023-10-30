using System;
using System.Collections.Generic;

namespace GeraClasse.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int IdCategory { get; set; }

    public int IdBranch { get; set; }

    public int IdStore { get; set; }

    public virtual Store? Store { get; set; }
}
