using Microsoft.EntityFrameworkCore;
using NovaPay.Integrator.Common.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Context
{
    public class NovaIntegratorContext : DbContext
    {
        public DbSet<Merchant>? Merchants { get; set; }

        public DbSet<FinancialInstitution>? FinancialInstitutions { get; set; }

        public DbSet<CustomerReference> CustomerReferences { get; set; }

        public DbSet<ProcessedTransaction> ProcessedTransactions { get; set; }

        public DbSet<RequestLog>? RequestLogs { get; set; }

        public DbSet<User>? Users { get; set; }

        public DbSet<UserCode> UserCodes { get; set; }

        public DbSet<FinancialInstitutionConfig> FinancialInstitutionConfigs { get; set; }

        public DbSet<Notification>? Notifications { get; set; }
        public DbSet<UserConnection>? UserConnections { get; set; }  

        public DbSet<RefreshToken> RefreshTokens { get; set; }


        public DbSet<MerchantConfig>? MerchantConfigs { get; set; }

        public DbSet<MerchantProcess>? MerchantProcesses { get; set; }

        public DbSet<MerchantLocalValidationConfig> MerchantLocalValidationConfigs { get; set; }

        public DbSet<MerchantGeneralApiConfig> MerchantGeneralApiConfigs { get; set; }

        public DbSet<MerchantValidationConfig> MerchantValidationConfigs { get; set; }

        public DbSet<MerchantApiConfig> MerchantApiConfigs { get; set; }
      
        public DbSet<TransactionReferenceNumber>? TransactionReferenceNumbers { get; set; }

        public DbSet<MerchantCategory>? MerchantCategories { get; set; }

        public DbSet<FinancialInstitutionCategory>? FinancialInstitutionCategories { get; set; }
        public NovaIntegratorContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
               

                //builder.UseMySQL("server=localhost;database=NovaIntegrator;uid=root;pwd=Nbs2020developers");
            }

            base.OnConfiguring(builder);
        }

        public NovaIntegratorContext(DbContextOptions<NovaIntegratorContext> options)
            : base(options)
        {
        }
    }
}
