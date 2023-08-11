using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaPay.Integrator.Common.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedFinancialInstitutionRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FinancialInstitutions_FinancialInstitutionConfigs_ConfigReco~",
                table: "FinancialInstitutions");

            migrationBuilder.DropIndex(
                name: "IX_FinancialInstitutions_ConfigRecordId",
                table: "FinancialInstitutions");

            migrationBuilder.DropColumn(
                name: "ConfigRecordId",
                table: "FinancialInstitutions");

            migrationBuilder.AddColumn<int>(
                name: "FinancialInstitutionRecordId",
                table: "FinancialInstitutionConfigs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FinancialInstitutionConfigs_FinancialInstitutionRecordId",
                table: "FinancialInstitutionConfigs",
                column: "FinancialInstitutionRecordId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FinancialInstitutionConfigs_FinancialInstitutions_FinancialI~",
                table: "FinancialInstitutionConfigs",
                column: "FinancialInstitutionRecordId",
                principalTable: "FinancialInstitutions",
                principalColumn: "RecordId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FinancialInstitutionConfigs_FinancialInstitutions_FinancialI~",
                table: "FinancialInstitutionConfigs");

            migrationBuilder.DropIndex(
                name: "IX_FinancialInstitutionConfigs_FinancialInstitutionRecordId",
                table: "FinancialInstitutionConfigs");

            migrationBuilder.DropColumn(
                name: "FinancialInstitutionRecordId",
                table: "FinancialInstitutionConfigs");

            migrationBuilder.AddColumn<int>(
                name: "ConfigRecordId",
                table: "FinancialInstitutions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FinancialInstitutions_ConfigRecordId",
                table: "FinancialInstitutions",
                column: "ConfigRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_FinancialInstitutions_FinancialInstitutionConfigs_ConfigReco~",
                table: "FinancialInstitutions",
                column: "ConfigRecordId",
                principalTable: "FinancialInstitutionConfigs",
                principalColumn: "RecordId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
