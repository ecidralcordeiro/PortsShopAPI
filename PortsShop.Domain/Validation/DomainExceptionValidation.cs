using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortsShop.Domain.Validation;

public class DomainExceptionValidation : Exception
{
    public DomainExceptionValidation(string errorMenssage) : base(errorMenssage) { }
    public static void When(bool hasError, string errorMenssage)
    {
        if(hasError)
        {
            throw new DomainExceptionValidation(errorMenssage);
        }
    }
}
