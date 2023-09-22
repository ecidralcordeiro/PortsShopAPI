using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortsShop.Domain.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int IdCategory { get; set; }
    public int IdBranch { get; set; }
    public int IdStore { get; set; }
    public Branch Branch  { get; private set; }
    public Store Store { get; private set; }
    public Category Category { get; private set; }

}
