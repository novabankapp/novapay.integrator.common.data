
using AutoMapper;
using NovaPay.Integrator.Common.Data.DTOs;
using NovaPay.Integrator.Common.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPay.Integrator.Common.Mapping
{
    public class MainProfile : Profile
    {
        public MainProfile()
        {

            CreateMap<Merchant, MerchantDto>()
                .ForMember(c => c.MerchantProcesses, opt => opt.MapFrom<MerchantProcessesResolver>())
                .ReverseMap();
            CreateMap<RequestLog, RequestLogDto>().ReverseMap();
            CreateMap<FinancialInstitution, FinancialInstitutionDto>()
                .ReverseMap();
            CreateMap<CustomerReference, CustomerReferenceDto>()
               .ReverseMap();
            CreateMap<ProcessedTransaction, ProcessedTransactionDto>()
             .ReverseMap();




        }
    }
}
