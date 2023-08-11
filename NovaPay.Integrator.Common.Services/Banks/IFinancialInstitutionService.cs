

using NovaPay.Integrator.Common.Data.DTOs;

namespace NovaPay.Integrator.Common.Services.Services.Services.Banks
{
    public interface IFinancialInstitutionService
    {
        Task<FinancialInstitutionDto> GetFinancialInstitutionAsync(string id);
    }
}