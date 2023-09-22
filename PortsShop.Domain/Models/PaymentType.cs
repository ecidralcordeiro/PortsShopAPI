using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortsShop.Domain.Models;

public class PaymentType
{
    public int Id { get; private set; }
    public string Number { get; private set; }
    public string Type { get; private set; }
    public DateTime Expiration {  get; private set; }
    public int SecurityCode { get; private set; }
}
