﻿
using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class MerchantCategoryDto : IDTO
    {
        public int RecordId { get; set; }
        public string? Name { get; set; }

        public ICollection<MerchantDto>? Merchants { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
