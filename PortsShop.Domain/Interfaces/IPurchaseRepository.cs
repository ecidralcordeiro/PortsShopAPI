﻿using PortsShop.Domain.Models;

namespace PortsShop.Domain.Interfaces;

public interface IPurchaseRepository
{
    Task<Purchase> CreateAsync(Purchase purchase);
    Task<Purchase> UpdateAsync(Purchase purchase);
    Task<Purchase> DeleteAsync(int id);
    Task<Purchase> GetByIdAsync(int id);
    Task<Purchase> AddSKU(SKU id);

    Task<Purchase> AddUser(User id);
    Task<Purchase> AddPrice(Price id);

    Task<IEnumerable<Purchase>> GetAllAsync();  
}
