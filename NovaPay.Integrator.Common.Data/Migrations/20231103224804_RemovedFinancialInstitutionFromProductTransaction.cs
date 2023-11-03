using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaPay.Integrator.Common.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedFinancialInstitutionFromProductTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTransactions_FinancialInstitutions_FinancialInstituti~",
                table: "ProductTransactions");

            migrationBuilder.DropIndex(
                name: "IX_ProductTransactions_FinancialInstitutionRecordId",
                table: "ProductTransactions");

            migrationBuilder.DropColumn(
                name: "FinancialInstitutionRecordId",
                table: "ProductTransactions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FinancialInstitutionRecordId",
                table: "ProductTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductTransactions_FinancialInstitutionRecordId",
                table: "ProductTransactions",
                column: "FinancialInstitutionRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTransactions_FinancialInstitutions_FinancialInstituti~",
                table: "ProductTransactions",
                column: "FinancialInstitutionRecordId",
                principalTable: "FinancialInstitutions",
                principalColumn: "RecordId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
