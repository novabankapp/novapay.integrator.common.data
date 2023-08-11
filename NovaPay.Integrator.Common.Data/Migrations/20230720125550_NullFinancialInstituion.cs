using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaPay.Integrator.Common.Data.Migrations
{
    /// <inheritdoc />
    public partial class NullFinancialInstituion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionReferenceNumbers_FinancialInstitutions_FinancialI~",
                table: "TransactionReferenceNumbers");

            migrationBuilder.AlterColumn<int>(
                name: "FinancialInstitutionRecordId",
                table: "TransactionReferenceNumbers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionReferenceNumbers_FinancialInstitutions_FinancialI~",
                table: "TransactionReferenceNumbers",
                column: "FinancialInstitutionRecordId",
                principalTable: "FinancialInstitutions",
                principalColumn: "RecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionReferenceNumbers_FinancialInstitutions_FinancialI~",
                table: "TransactionReferenceNumbers");

            migrationBuilder.AlterColumn<int>(
                name: "FinancialInstitutionRecordId",
                table: "TransactionReferenceNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionReferenceNumbers_FinancialInstitutions_FinancialI~",
                table: "TransactionReferenceNumbers",
                column: "FinancialInstitutionRecordId",
                principalTable: "FinancialInstitutions",
                principalColumn: "RecordId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
