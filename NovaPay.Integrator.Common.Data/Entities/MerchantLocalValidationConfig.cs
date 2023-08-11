﻿using Common.Libraries.Services.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.Entities
{
    public class MerchantLocalValidationConfig : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }

        public int MerchantValidationConfigRecordId { get; set; }

        public string TableName { get; set; }

        public DateTime LastUpdated { get; set; }
    }
    
}
