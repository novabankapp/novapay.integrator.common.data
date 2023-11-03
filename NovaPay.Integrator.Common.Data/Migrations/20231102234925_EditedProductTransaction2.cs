using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaPay.Integrator.Common.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditedProductTransaction2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTransactions_FinancialInstitutions_FinancialInstituti~",
                table: "ProductTransactions");

            migrationBuilder.DropIndex(
                name: "IX_ProductTransactions_FinancialInstitutionRecordId1",
                table: "ProductTransactions");

            migrationBuilder.DropColumn(
                name: "FinancialInstitutionRecordId1",
                table: "ProductTransactions");

            migrationBuilder.AlterColumn<int>(
                name: "FinancialInstitutionRecordId",
                table: "ProductTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTransactions_FinancialInstitutions_FinancialInstituti~",
                table: "ProductTransactions");

            migrationBuilder.DropIndex(
                name: "IX_ProductTransactions_FinancialInstitutionRecordId",
                table: "ProductTransactions");

            migrationBuilder.AlterColumn<string>(
                name: "FinancialInstitutionRecordId",
                table: "ProductTransactions",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "FinancialInstitutionRecordId1",
                table: "ProductTransactions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductTransactions_FinancialInstitutionRecordId1",
                table: "ProductTransactions",
                column: "FinancialInstitutionRecordId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTransactions_FinancialInstitutions_FinancialInstituti~",
                table: "ProductTransactions",
                column: "FinancialInstitutionRecordId1",
                principalTable: "FinancialInstitutions",
                principalColumn: "RecordId");
        }
    }
}
