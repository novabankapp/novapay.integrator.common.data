
using Common.Libraries.Services.Services;
using NovaPay.Integrator.Common.Data.DTOs;
using NovaPay.Integrator.Common.Data.Entities;
using NovaPay.Integrator.Common.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Services.Services.Services.Banks
{
    public class FinancialInstitutionService : IFinancialInstitutionService
    {
        private readonly IService<FinancialInstitution, FinancialInstitutionDto> _financialInstitutionService;

        public FinancialInstitutionService(IService<FinancialInstitution, FinancialInstitutionDto> financialInstitutionService)
        {
            _financialInstitutionService = financialInstitutionService;
        }
        public async Task<FinancialInstitutionDto> GetFinancialInstitutionAsync(string id)
        {
            var response = await _financialInstitutionService.GetOneAsync(f => f.UniqueIdentifier == id);
            if (response != null)
            {
                return MappingInstance.MainMapper.Map<FinancialInstitutionDto>(response);
            }
            throw new Exception("Institution Not Found");
        }
    }
}
