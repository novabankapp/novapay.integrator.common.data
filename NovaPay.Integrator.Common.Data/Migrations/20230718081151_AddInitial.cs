using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace NovaPay.Integrator.Common.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FinancialInstitutionCategories",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialInstitutionCategories", x => x.RecordId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FinancialInstitutionConfigs",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    PaymentEventWebhook = table.Column<string>(type: "longtext", nullable: true),
                    PaymentEventWebhookId = table.Column<string>(type: "longtext", nullable: true),
                    PaymentEventWebhookSecret = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialInstitutionConfigs", x => x.RecordId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MerchantCategories",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantCategories", x => x.RecordId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserCodes",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "longtext", nullable: false),
                    Code = table.Column<string>(type: "longtext", nullable: false),
                    Token = table.Column<string>(type: "longtext", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCodes", x => x.RecordId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    FullName = table.Column<string>(type: "longtext", nullable: false),
                    PrivateKey = table.Column<string>(type: "longtext", nullable: false),
                    IsLocked = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsVerified = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeactivated = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PublicKey = table.Column<string>(type: "longtext", nullable: false),
                    ProfilePicPath = table.Column<string>(type: "longtext", nullable: false),
                    UserName = table.Column<string>(type: "longtext", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "longtext", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "longtext", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FinancialInstitutions",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    UniqueIdentifier = table.Column<string>(type: "varchar(255)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FinancialServiceName = table.Column<string>(type: "longtext", nullable: false),
                    FinancialInstitutionCategoryRecordId = table.Column<int>(type: "int", nullable: false),
                    ConfigRecordId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialInstitutions", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_FinancialInstitutions_FinancialInstitutionCategories_Financi~",
                        column: x => x.FinancialInstitutionCategoryRecordId,
                        principalTable: "FinancialInstitutionCategories",
                        principalColumn: "RecordId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FinancialInstitutions_FinancialInstitutionConfigs_ConfigReco~",
                        column: x => x.ConfigRecordId,
                        principalTable: "FinancialInstitutionConfigs",
                        principalColumn: "RecordId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Merchants",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UniqueIdentifier = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ShortCode = table.Column<string>(type: "longtext", nullable: true),
                    MerchantCategoryRecordId = table.Column<int>(type: "int", nullable: false),
                    ServiceName = table.Column<string>(type: "longtext", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchants", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_Merchants_MerchantCategories_MerchantCategoryRecordId",
                        column: x => x.MerchantCategoryRecordId,
                        principalTable: "MerchantCategories",
                        principalColumn: "RecordId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    Message = table.Column<string>(type: "longtext", nullable: false),
                    Seen = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Token = table.Column<string>(type: "longtext", nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedByIp = table.Column<string>(type: "longtext", nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    RevokedByIp = table.Column<string>(type: "longtext", nullable: false),
                    ReplacedByToken = table.Column<string>(type: "longtext", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserConnections",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ConnectionId = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserConnections", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_UserConnections_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MerchantConfigs",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    MerchantRecordId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantConfigs", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_MerchantConfigs_Merchants_MerchantRecordId",
                        column: x => x.MerchantRecordId,
                        principalTable: "Merchants",
                        principalColumn: "RecordId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MerchantProcesses",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    MerchantRecordId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsAsync = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsValidation = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsPostTransaction = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantProcesses", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_MerchantProcesses_Merchants_MerchantRecordId",
                        column: x => x.MerchantRecordId,
                        principalTable: "Merchants",
                        principalColumn: "RecordId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RequestLogs",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FinancialServiceId = table.Column<string>(type: "longtext", nullable: true),
                    MerchantId = table.Column<string>(type: "longtext", nullable: true),
                    RequestUrl = table.Column<string>(type: "longtext", nullable: true),
                    RawRequest = table.Column<string>(type: "longtext", nullable: true),
                    RawResponse = table.Column<string>(type: "longtext", nullable: true),
                    ResponseStatusCode = table.Column<int>(type: "int", nullable: true),
                    Message = table.Column<string>(type: "longtext", nullable: true),
                    RequestTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ResponseTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    FinancialInstitutionRecordId = table.Column<int>(type: "int", nullable: true),
                    MerchantRecordId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestLogs", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_RequestLogs_FinancialInstitutions_FinancialInstitutionRecord~",
                        column: x => x.FinancialInstitutionRecordId,
                        principalTable: "FinancialInstitutions",
                        principalColumn: "RecordId");
                    table.ForeignKey(
                        name: "FK_RequestLogs_Merchants_MerchantRecordId",
                        column: x => x.MerchantRecordId,
                        principalTable: "Merchants",
                        principalColumn: "RecordId");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransactionReferenceNumbers",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TRN = table.Column<string>(type: "varchar(255)", nullable: true),
                    CustomerReference = table.Column<string>(type: "longtext", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Used = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UserId = table.Column<string>(type: "longtext", nullable: false),
                    ServiceUniqueIdentifier = table.Column<string>(type: "longtext", nullable: true),
                    FinancialServiceUniqueIdentifier = table.Column<string>(type: "longtext", nullable: true),
                    MerchantRecordId = table.Column<int>(type: "int", nullable: false),
                    CustomerDetails = table.Column<string>(type: "longtext", nullable: true),
                    QRCodePath = table.Column<string>(type: "longtext", nullable: true),
                    FinancialInstitutionRecordId = table.Column<int>(type: "int", nullable: false),
                    Metadata = table.Column<string>(type: "longtext", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionReferenceNumbers", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_TransactionReferenceNumbers_FinancialInstitutions_FinancialI~",
                        column: x => x.FinancialInstitutionRecordId,
                        principalTable: "FinancialInstitutions",
                        principalColumn: "RecordId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionReferenceNumbers_Merchants_MerchantRecordId",
                        column: x => x.MerchantRecordId,
                        principalTable: "Merchants",
                        principalColumn: "RecordId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MerchantApiConfigs",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IsCustom = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MerchantConfigRecordId = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantApiConfigs", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_MerchantApiConfigs_MerchantConfigs_MerchantConfigRecordId",
                        column: x => x.MerchantConfigRecordId,
                        principalTable: "MerchantConfigs",
                        principalColumn: "RecordId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MerchantApiKeyConfig",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ApiSecretKey = table.Column<string>(type: "longtext", nullable: true),
                    ApiPublishableKey = table.Column<string>(type: "longtext", nullable: true),
                    MerchantConfigRecordId = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantApiKeyConfig", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_MerchantApiKeyConfig_MerchantConfigs_MerchantConfigRecordId",
                        column: x => x.MerchantConfigRecordId,
                        principalTable: "MerchantConfigs",
                        principalColumn: "RecordId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MerchantValidationConfigs",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IsLocal = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MerchantConfigRecordId = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantValidationConfigs", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_MerchantValidationConfigs_MerchantConfigs_MerchantConfigReco~",
                        column: x => x.MerchantConfigRecordId,
                        principalTable: "MerchantConfigs",
                        principalColumn: "RecordId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MerchantWebhookConfig",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MerchantConfigRecordId = table.Column<int>(type: "int", nullable: false),
                    PaymentEventWebhook = table.Column<string>(type: "longtext", nullable: true),
                    PaymentEventWebhookSecret = table.Column<string>(type: "longtext", nullable: true),
                    PaymentEventWebhookId = table.Column<string>(type: "longtext", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantWebhookConfig", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_MerchantWebhookConfig_MerchantConfigs_MerchantConfigRecordId",
                        column: x => x.MerchantConfigRecordId,
                        principalTable: "MerchantConfigs",
                        principalColumn: "RecordId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MerchantGeneralApiConfigs",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BaseUrl = table.Column<string>(type: "longtext", nullable: false),
                    MerchantApiConfigRecordId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantGeneralApiConfigs", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_MerchantGeneralApiConfigs_MerchantApiConfigs_MerchantApiConf~",
                        column: x => x.MerchantApiConfigRecordId,
                        principalTable: "MerchantApiConfigs",
                        principalColumn: "RecordId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MerchantLocalValidationConfigs",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MerchantValidationConfigRecordId = table.Column<int>(type: "int", nullable: false),
                    TableName = table.Column<string>(type: "longtext", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantLocalValidationConfigs", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_MerchantLocalValidationConfigs_MerchantValidationConfigs_Mer~",
                        column: x => x.MerchantValidationConfigRecordId,
                        principalTable: "MerchantValidationConfigs",
                        principalColumn: "RecordId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialInstitutions_ConfigRecordId",
                table: "FinancialInstitutions",
                column: "ConfigRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialInstitutions_FinancialInstitutionCategoryRecordId",
                table: "FinancialInstitutions",
                column: "FinancialInstitutionCategoryRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialInstitutions_UniqueIdentifier",
                table: "FinancialInstitutions",
                column: "UniqueIdentifier",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MerchantApiConfigs_MerchantConfigRecordId",
                table: "MerchantApiConfigs",
                column: "MerchantConfigRecordId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MerchantApiKeyConfig_MerchantConfigRecordId",
                table: "MerchantApiKeyConfig",
                column: "MerchantConfigRecordId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MerchantConfigs_MerchantRecordId",
                table: "MerchantConfigs",
                column: "MerchantRecordId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MerchantGeneralApiConfigs_MerchantApiConfigRecordId",
                table: "MerchantGeneralApiConfigs",
                column: "MerchantApiConfigRecordId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MerchantLocalValidationConfigs_MerchantValidationConfigRecor~",
                table: "MerchantLocalValidationConfigs",
                column: "MerchantValidationConfigRecordId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MerchantProcesses_MerchantRecordId",
                table: "MerchantProcesses",
                column: "MerchantRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Merchants_MerchantCategoryRecordId",
                table: "Merchants",
                column: "MerchantCategoryRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Merchants_UniqueIdentifier",
                table: "Merchants",
                column: "UniqueIdentifier",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MerchantValidationConfigs_MerchantConfigRecordId",
                table: "MerchantValidationConfigs",
                column: "MerchantConfigRecordId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MerchantWebhookConfig_MerchantConfigRecordId",
                table: "MerchantWebhookConfig",
                column: "MerchantConfigRecordId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestLogs_FinancialInstitutionRecordId",
                table: "RequestLogs",
                column: "FinancialInstitutionRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestLogs_MerchantRecordId",
                table: "RequestLogs",
                column: "MerchantRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionReferenceNumbers_FinancialInstitutionRecordId",
                table: "TransactionReferenceNumbers",
                column: "FinancialInstitutionRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionReferenceNumbers_MerchantRecordId",
                table: "TransactionReferenceNumbers",
                column: "MerchantRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionReferenceNumbers_TRN",
                table: "TransactionReferenceNumbers",
                column: "TRN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserConnections_UserId",
                table: "UserConnections",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MerchantApiKeyConfig");

            migrationBuilder.DropTable(
                name: "MerchantGeneralApiConfigs");

            migrationBuilder.DropTable(
                name: "MerchantLocalValidationConfigs");

            migrationBuilder.DropTable(
                name: "MerchantProcesses");

            migrationBuilder.DropTable(
                name: "MerchantWebhookConfig");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "RequestLogs");

            migrationBuilder.DropTable(
                name: "TransactionReferenceNumbers");

            migrationBuilder.DropTable(
                name: "UserCodes");

            migrationBuilder.DropTable(
                name: "UserConnections");

            migrationBuilder.DropTable(
                name: "MerchantApiConfigs");

            migrationBuilder.DropTable(
                name: "MerchantValidationConfigs");

            migrationBuilder.DropTable(
                name: "FinancialInstitutions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "MerchantConfigs");

            migrationBuilder.DropTable(
                name: "FinancialInstitutionCategories");

            migrationBuilder.DropTable(
                name: "FinancialInstitutionConfigs");

            migrationBuilder.DropTable(
                name: "Merchants");

            migrationBuilder.DropTable(
                name: "MerchantCategories");
        }
    }
}
