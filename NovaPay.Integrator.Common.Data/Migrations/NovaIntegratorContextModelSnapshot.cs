﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NovaPay.Integrator.Common.Context;

#nullable disable

namespace NovaPay.Integrator.Common.Data.Migrations
{
    [DbContext(typeof(NovaIntegratorContext))]
    partial class NovaIntegratorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.CustomerReference", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CustomerRef")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ServiceUniqueIdentifier")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("RecordId");

                    b.HasIndex("ServiceUniqueIdentifier")
                        .IsUnique();

                    b.ToTable("CustomerReferences");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.FinancialInstitution", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FinancialInstitutionCategoryRecordId")
                        .HasColumnType("int");

                    b.Property<string>("FinancialServiceName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("UniqueIdentifier")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("RecordId");

                    b.HasIndex("FinancialInstitutionCategoryRecordId");

                    b.HasIndex("UniqueIdentifier")
                        .IsUnique();

                    b.ToTable("FinancialInstitutions");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.FinancialInstitutionCategory", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("RecordId");

                    b.ToTable("FinancialInstitutionCategories");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.FinancialInstitutionConfig", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FinancialInstitutionRecordId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentEventWebhook")
                        .HasColumnType("longtext");

                    b.Property<string>("PaymentEventWebhookId")
                        .HasColumnType("longtext");

                    b.Property<string>("PaymentEventWebhookSecret")
                        .HasColumnType("longtext");

                    b.HasKey("RecordId");

                    b.HasIndex("FinancialInstitutionRecordId")
                        .IsUnique();

                    b.ToTable("FinancialInstitutionConfigs");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.Merchant", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("MerchantCategoryRecordId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("ServiceName")
                        .HasColumnType("longtext");

                    b.Property<string>("ShortCode")
                        .HasColumnType("longtext");

                    b.Property<string>("UniqueIdentifier")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("RecordId");

                    b.HasIndex("MerchantCategoryRecordId");

                    b.HasIndex("UniqueIdentifier")
                        .IsUnique();

                    b.ToTable("Merchants");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantApiConfig", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsCustom")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MerchantConfigRecordId")
                        .HasColumnType("int");

                    b.HasKey("RecordId");

                    b.HasIndex("MerchantConfigRecordId")
                        .IsUnique();

                    b.ToTable("MerchantApiConfigs");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantApiKeyConfig", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ApiPublishableKey")
                        .HasColumnType("longtext");

                    b.Property<string>("ApiSecretKey")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MerchantConfigRecordId")
                        .HasColumnType("int");

                    b.HasKey("RecordId");

                    b.HasIndex("MerchantConfigRecordId")
                        .IsUnique();

                    b.ToTable("MerchantApiKeyConfig");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantCategory", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("RecordId");

                    b.ToTable("MerchantCategories");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantConfig", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MerchantRecordId")
                        .HasColumnType("int");

                    b.HasKey("RecordId");

                    b.HasIndex("MerchantRecordId")
                        .IsUnique();

                    b.ToTable("MerchantConfigs");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantGeneralApiConfig", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BaseUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MerchantApiConfigRecordId")
                        .HasColumnType("int");

                    b.HasKey("RecordId");

                    b.HasIndex("MerchantApiConfigRecordId")
                        .IsUnique();

                    b.ToTable("MerchantGeneralApiConfigs");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantLocalValidationConfig", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MerchantValidationConfigRecordId")
                        .HasColumnType("int");

                    b.Property<string>("TableName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RecordId");

                    b.HasIndex("MerchantValidationConfigRecordId")
                        .IsUnique();

                    b.ToTable("MerchantLocalValidationConfigs");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantProcess", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsAsync")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsPostTransaction")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsValidation")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("MerchantRecordId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RecordId");

                    b.HasIndex("MerchantRecordId");

                    b.ToTable("MerchantProcesses");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantValidationConfig", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsLocal")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MerchantConfigRecordId")
                        .HasColumnType("int");

                    b.HasKey("RecordId");

                    b.HasIndex("MerchantConfigRecordId")
                        .IsUnique();

                    b.ToTable("MerchantValidationConfigs");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantWebhookConfig", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MerchantConfigRecordId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentEventWebhook")
                        .HasColumnType("longtext");

                    b.Property<string>("PaymentEventWebhookId")
                        .HasColumnType("longtext");

                    b.Property<string>("PaymentEventWebhookSecret")
                        .HasColumnType("longtext");

                    b.HasKey("RecordId");

                    b.HasIndex("MerchantConfigRecordId")
                        .IsUnique();

                    b.ToTable("MerchantWebhookConfig");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.Notification", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Seen")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("RecordId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.ProcessedTransaction", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CustomerRef")
                        .HasColumnType("longtext");

                    b.Property<string>("ServiceUniqueIdentifier")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("TransactionRef")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RecordId");

                    b.HasIndex("ServiceUniqueIdentifier")
                        .IsUnique();

                    b.ToTable("ProcessedTransactions");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.RefreshToken", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreatedByIp")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ReplacedByToken")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("RevokedByIp")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("RecordId");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.RequestLog", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("FinancialInstitutionRecordId")
                        .HasColumnType("int");

                    b.Property<string>("FinancialServiceId")
                        .HasColumnType("longtext");

                    b.Property<string>("MerchantId")
                        .HasColumnType("longtext");

                    b.Property<int?>("MerchantRecordId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("longtext");

                    b.Property<string>("RawRequest")
                        .HasColumnType("longtext");

                    b.Property<string>("RawResponse")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("RequestTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("RequestUrl")
                        .HasColumnType("longtext");

                    b.Property<int?>("ResponseStatusCode")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ResponseTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("RecordId");

                    b.HasIndex("FinancialInstitutionRecordId");

                    b.HasIndex("MerchantRecordId");

                    b.ToTable("RequestLogs");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.TransactionReferenceNumber", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal?>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CustomerDetails")
                        .HasColumnType("longtext");

                    b.Property<string>("CustomerReference")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("FinancialInstitutionRecordId")
                        .HasColumnType("int");

                    b.Property<string>("FinancialServiceUniqueIdentifier")
                        .HasColumnType("longtext");

                    b.Property<int>("MerchantRecordId")
                        .HasColumnType("int");

                    b.Property<string>("Metadata")
                        .HasColumnType("longtext");

                    b.Property<string>("QRCodePath")
                        .HasColumnType("longtext");

                    b.Property<string>("ServiceUniqueIdentifier")
                        .HasColumnType("longtext");

                    b.Property<string>("TRN")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Used")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RecordId");

                    b.HasIndex("FinancialInstitutionRecordId");

                    b.HasIndex("MerchantRecordId");

                    b.HasIndex("TRN")
                        .IsUnique();

                    b.ToTable("TransactionReferenceNumbers");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeactivated")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("PrivateKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProfilePicPath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PublicKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.UserCode", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RecordId");

                    b.ToTable("UserCodes");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.UserConnection", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConnectionId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("RecordId");

                    b.HasIndex("UserId");

                    b.ToTable("UserConnections");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.FinancialInstitution", b =>
                {
                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.FinancialInstitutionCategory", "FinancialInstitutionCategory")
                        .WithMany("Institutions")
                        .HasForeignKey("FinancialInstitutionCategoryRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FinancialInstitutionCategory");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.FinancialInstitutionConfig", b =>
                {
                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.FinancialInstitution", "FinancialInstitution")
                        .WithOne("Config")
                        .HasForeignKey("NovaPay.Integrator.Common.Data.Entities.FinancialInstitutionConfig", "FinancialInstitutionRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FinancialInstitution");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.Merchant", b =>
                {
                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.MerchantCategory", "MerchantCategory")
                        .WithMany("Merchants")
                        .HasForeignKey("MerchantCategoryRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MerchantCategory");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantApiConfig", b =>
                {
                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.MerchantConfig", "MerchantConfig")
                        .WithOne("ApiConfig")
                        .HasForeignKey("NovaPay.Integrator.Common.Data.Entities.MerchantApiConfig", "MerchantConfigRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MerchantConfig");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantApiKeyConfig", b =>
                {
                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.MerchantConfig", "MerchantConfig")
                        .WithOne("ApiKeyConfig")
                        .HasForeignKey("NovaPay.Integrator.Common.Data.Entities.MerchantApiKeyConfig", "MerchantConfigRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MerchantConfig");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantConfig", b =>
                {
                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.Merchant", "Merchant")
                        .WithOne("MerchantConfig")
                        .HasForeignKey("NovaPay.Integrator.Common.Data.Entities.MerchantConfig", "MerchantRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Merchant");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantGeneralApiConfig", b =>
                {
                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.MerchantApiConfig", "MerchantApiConfig")
                        .WithOne("GeneralApiConfig")
                        .HasForeignKey("NovaPay.Integrator.Common.Data.Entities.MerchantGeneralApiConfig", "MerchantApiConfigRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MerchantApiConfig");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantLocalValidationConfig", b =>
                {
                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.MerchantValidationConfig", null)
                        .WithOne("LocalValidationConfig")
                        .HasForeignKey("NovaPay.Integrator.Common.Data.Entities.MerchantLocalValidationConfig", "MerchantValidationConfigRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantProcess", b =>
                {
                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.Merchant", "Merchant")
                        .WithMany("MerchantProcesses")
                        .HasForeignKey("MerchantRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Merchant");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantValidationConfig", b =>
                {
                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.MerchantConfig", "MerchantConfig")
                        .WithOne("ValidationConfig")
                        .HasForeignKey("NovaPay.Integrator.Common.Data.Entities.MerchantValidationConfig", "MerchantConfigRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MerchantConfig");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantWebhookConfig", b =>
                {
                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.MerchantConfig", "MerchantConfig")
                        .WithOne("WebhookConfig")
                        .HasForeignKey("NovaPay.Integrator.Common.Data.Entities.MerchantWebhookConfig", "MerchantConfigRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MerchantConfig");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.Notification", b =>
                {
                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.RefreshToken", b =>
                {
                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.RequestLog", b =>
                {
                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.FinancialInstitution", null)
                        .WithMany("RequestLogs")
                        .HasForeignKey("FinancialInstitutionRecordId");

                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.Merchant", null)
                        .WithMany("RequestLogs")
                        .HasForeignKey("MerchantRecordId");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.TransactionReferenceNumber", b =>
                {
                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.FinancialInstitution", "FinancialInstitution")
                        .WithMany("TRNs")
                        .HasForeignKey("FinancialInstitutionRecordId");

                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.Merchant", "Merchant")
                        .WithMany("TRNs")
                        .HasForeignKey("MerchantRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FinancialInstitution");

                    b.Navigation("Merchant");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.UserConnection", b =>
                {
                    b.HasOne("NovaPay.Integrator.Common.Data.Entities.User", "User")
                        .WithMany("Connections")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.FinancialInstitution", b =>
                {
                    b.Navigation("Config")
                        .IsRequired();

                    b.Navigation("RequestLogs");

                    b.Navigation("TRNs");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.FinancialInstitutionCategory", b =>
                {
                    b.Navigation("Institutions");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.Merchant", b =>
                {
                    b.Navigation("MerchantConfig");

                    b.Navigation("MerchantProcesses");

                    b.Navigation("RequestLogs");

                    b.Navigation("TRNs");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantApiConfig", b =>
                {
                    b.Navigation("GeneralApiConfig");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantCategory", b =>
                {
                    b.Navigation("Merchants");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantConfig", b =>
                {
                    b.Navigation("ApiConfig")
                        .IsRequired();

                    b.Navigation("ApiKeyConfig");

                    b.Navigation("ValidationConfig");

                    b.Navigation("WebhookConfig");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.MerchantValidationConfig", b =>
                {
                    b.Navigation("LocalValidationConfig");
                });

            modelBuilder.Entity("NovaPay.Integrator.Common.Data.Entities.User", b =>
                {
                    b.Navigation("Connections");

                    b.Navigation("Notifications");

                    b.Navigation("RefreshTokens");
                });
#pragma warning restore 612, 618
        }
    }
}
