

using NovaPay.Integrator.Common.Data.DTOs;
using NovaPay.Integrator.Common.Data.Entities;

namespace NovaPay.Integrator.Common.Services.Services.Merchants
{
    public interface IMerchantService
    {
        Task<Merchant> GetMerchantByIdAsync(string merchantId);
    }
}