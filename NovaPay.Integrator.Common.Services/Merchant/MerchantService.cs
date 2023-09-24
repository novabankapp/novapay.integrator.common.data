
using Common.Libraries.Services.Services;
using NovaPay.Integrator.Common.Data.DTOs;
using NovaPay.Integrator.Common.Data.Entities;
using NovaPay.Integrator.Common.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Services.Services.Merchants
{
    public class MerchantService : IMerchantService
    {
        private readonly IService<Merchant, MerchantDto> _merchantService;

        public MerchantService(IService<Merchant, MerchantDto> merchantService)
        {
            _merchantService = merchantService;
        }
        public async Task<Merchant> GetMerchantByIdAsync(string merchantId)
        {
            var response = await _merchantService.GetOneAsync(
                t => t.UniqueIdentifier == merchantId && t.IsActive, null,
                new string[] {  nameof(Merchant.MerchantCategory), nameof(Merchant.TRNs)
                           , nameof(Merchant.MerchantConfig), nameof(Merchant.MerchantProcesses),
                             $"{nameof(Merchant.MerchantConfig)}.{nameof(MerchantConfig.ValidationConfig)}",
                             $"{nameof(Merchant.MerchantConfig)}.{nameof(MerchantConfig.WebhookConfig)}",
                             $"{nameof(Merchant.MerchantConfig)}.{nameof(MerchantConfig.ApiConfig)}",
                             $"{nameof(Merchant.MerchantConfig)}.{nameof(MerchantConfig.ApiKeyConfig)}",
                              nameof(Merchant.MerchantPaymentResponseMappings), nameof(Merchant.MerchantValidationResponseMappings),
                             $"{nameof(Merchant.MerchantConfig)}.{nameof(MerchantConfig.ApiConfig)}.{nameof(MerchantApiConfig.GeneralApiConfig)}"}); 
            if (response != null)
            {
                
                return response;
            }
            throw new Exception("Merchant Not Found");
        }
    }
}
