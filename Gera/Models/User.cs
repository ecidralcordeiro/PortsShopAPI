using System;
using System.Collections.Generic;

namespace GeraClasse.Models;

public partial class User
{
    public int Id { get; set; }

    public int? IdPerson { get; set; }

    public int? IdStore { get; set; }

    public int? IdAdress { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Address? Address { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Person? Person { get; set; }

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();

    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}
