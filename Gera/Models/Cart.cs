using System;
using System.Collections.Generic;

namespace GeraClasse.Models;

public partial class Cart
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public int IdSku { get; set; }

    public virtual Sku IdSkuNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
