using PortsShop.Domain.Validation;

namespace PortsShop.Domain.Models;

public class Person
{
    public int Id { get; private set; }
    public DateTime Birthday { get; private set; }
    public string? CPF { get; private set; }
    public string? Identity { get; private set; }
    public string? Passport { get; private set; }

    public Person(){}
    public Person(DateTime birthday, string? cpf = null, string? identity = null, string? passport = null)
    {
        ValidateDomain(birthday, cpf, identity, passport);
    }

    private void ValidateDomain(DateTime birthday, string? cpf = null, string? identity = null, string? passport = null)
    {
        DomainExceptionValidation.When(PersonValidation.IsOlderThan16(birthday), "Menor idade");
        DomainExceptionValidation.When(!PersonValidation.ValidateCPF(cpf), "CPF invalid");

        Birthday = birthday;
        CPF = cpf;
        Identity = identity;
        Passport = passport;
    }


}
