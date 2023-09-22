using PortsShop.Domain.Validation;
using System;

namespace PortsShop.Domain.Models
{
    public class User
    {
        public int Id { get; private set; }
        public int? IdPerson { get; private set; }
        public int? IdStore { get; private set; }
        public int? idAdress { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public Person Person { get; private set; }
        public Address Address { get; private set; }
        public ICollection<Cart> Carts { get;  set; }
        public ICollection<Purchase> Purchases { get;  set; }

        public User(string email, string password)
        {
            ValidateDomain(email, password);
        }

        public void Update(int id, string email, string password)
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
        public void AssociatePerson(int personId)
        {
            IdPerson = personId;
            IdStore = null;
        }
        public void AssociateStore(int storeId)
        {
            IdStore = storeId;
            IdPerson = null;
        }
    }
}
