using PortsShop.Domain.Untils;
using PortsShop.Domain.Validation;
using System;
using System.Reflection.Metadata.Ecma335;

namespace PortsShop.Domain.Models;

public class Store
{
    public int Id { get; private set; }
    public string CompanyName { get; private set; }
    public string FantasyName { get; private set; }
    public string CNPJ { get; private set; }
    public int IdUser { get; private set; }
    public int IdAdress { get; private set; }
    public Address Address { get; private set; }
    public User User { get; private set; }
    public Store()
    {
    }

    public Store(string companyName, string fantasyName, string cnpj, int userId)
    {
        ValidateDomain(companyName, fantasyName, cnpj, userId);
    }

    public void Update(int id, string companyName, string fantasyName, string cnpj, int userId)
    {
        Id = id;
        ValidateDomain(companyName, fantasyName, cnpj, userId);
    }

    private void ValidateDomain(string companyName, string fantasyName, string cnpj, int userId)
    {
        DomainExceptionValidation.When(string.IsNullOrWhiteSpace(companyName), "Nome da empresa é obrigatório");
        DomainExceptionValidation.When(string.IsNullOrWhiteSpace(cnpj) || cnpj.Length != 14 || !DataUtils.IsAllDigits(cnpj), "CNPJ inválido");

        CompanyName = companyName;
        FantasyName = fantasyName;
        CNPJ = cnpj;
        IdUser = userId;
    }

}
