using AutoMapper;
using NovaPay.Integrator.Common.Data.DTOs;
using NovaPay.Integrator.Common.Data.Entities;

namespace NovaPay.Integrator.Common.Mapping
{
    public class MerchantProcessesResolver : IValueResolver<Merchant, MerchantDto, ICollection<MerchantProcessDto>>
    {
        public ICollection<MerchantProcessDto> Resolve(Merchant source, MerchantDto destination, ICollection<MerchantProcessDto> destMember, ResolutionContext context)
        {
            var processes = source.MerchantProcesses;
            var processDtos = new List<MerchantProcessDto>();
            var iter = processes.GetEnumerator();
            while (iter.MoveNext())
            {
                var process = iter.Current;
                processDtos.Add(new MerchantProcessDto()
                {
                    RecordId = process.RecordId,
                    Name = process.Name,
                    CreatedAt = process.CreatedAt,
                    IsAsync = process.IsAsync,
                    IsPostTransaction = process.IsPostTransaction,
                    IsValidation = process.IsValidation,
                    MerchantRecordId = process.MerchantRecordId,
                });
            }



            return processDtos;
        }
    }
}