using PortsShop.Domain.Validation;
using System;

namespace PortsShop.Domain.Models
{
    public class User
    {
        public long Id { get; private set; }
        public long? IdPerson { get; private set; }
        public long? IdStore { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public Person Person { get; private set; }

        public User(string email, string password)
        {
            ValidateDomain(email, password);
        }

        public void Update(long id, string email, string password)
        {
            Id = id;
            ValidateDomain(email, password);
        }
        private void ValidateDomain(string email, string password)
        {
            DomainExceptionValidation.When(!email.Contains('@') || !email.Contains('.'), "Email inválido");
            DomainExceptionValidation.When(password.Length < 8, "Mínimo 8 caracteres");

            Email = email;
            Password = password;
        }
        public void AssociatePerson(long personId)
        {
            IdPerson = personId;
            IdStore = null;
        }
        public void AssociateStore(long storeId)
        {
            IdStore = storeId;
            IdPerson = null;
        }
    }
}
