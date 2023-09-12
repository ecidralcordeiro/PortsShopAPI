using PortsShop.Domain.Untils;
using PortsShop.Domain.Validation;
using System;

namespace PortsShop.Domain.Models
{
    public class Store
    {
        public long Id { get; private set; }
        public string CompanyName { get; private set; }
        public string FantasyName { get; private set; }
        public string CNPJ { get; private set; }

        public Store(string companyName, string fantasyName, string cnpj)
        {
            ValidateDomain(companyName, fantasyName, cnpj);
        }

        public void Update(long id, string companyName, string fantasyName, string cnpj)
        {
            Id = id;
            ValidateDomain(companyName, fantasyName, cnpj);
        }

        private void ValidateDomain(string companyName, string fantasyName, string cnpj)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(companyName), "Nome da empresa é obrigatório");
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(cnpj) || cnpj.Length != 14 || !DataUtils.IsAllDigits(cnpj), "CNPJ inválido");

            CompanyName = companyName;
            FantasyName = fantasyName;
            CNPJ = cnpj;
        }

      
    }
}
