using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Interfaces;
using PortsShop.Domain.Models;
using PortsShop.Infra.Data.Context;
using System.Data;

namespace PortsShop.Infra.Data.Repositories;


public class PaymentTypeRepository : IPaymentTypeRepository
{
    private readonly ApplicationDbContext _context;
    public PaymentTypeRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<PaymentType> CreateAsync(PaymentType paymentType)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentType> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PaymentType>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<PaymentType> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentType> UpdateAsync(PaymentType paymentType)
    {
        throw new NotImplementedException();
    }
}
