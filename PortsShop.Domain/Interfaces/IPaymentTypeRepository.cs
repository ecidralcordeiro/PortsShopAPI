using PortsShop.Domain.Models;

namespace PortsShop.Domain.Interfaces;

public interface IPaymentTypeRepository
{
    Task<PaymentType> CreateAsync(PaymentType paymentType);
    Task<PaymentType> UpdateAsync(PaymentType paymentType);
    Task<PaymentType> DeleteAsync(int id);
    Task<PaymentType> GetByIdAsync(int id);
    Task<IEnumerable<PaymentType>> GetAllAsync();  
}
