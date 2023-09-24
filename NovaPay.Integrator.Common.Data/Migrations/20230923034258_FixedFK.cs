using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaPay.Integrator.Common.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixedFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MerchantPaymentResponseMappings_Merchants_MerchantRecordId",
                table: "MerchantPaymentResponseMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_MerchantValidationResponseMappings_Merchants_MerchantRecordId",
                table: "MerchantValidationResponseMappings");

            migrationBuilder.DropColumn(
                name: "MerchantConfigRecordId",
                table: "MerchantValidationResponseMappings");

            migrationBuilder.DropColumn(
                name: "MerchantConfigRecordId",
                table: "MerchantPaymentResponseMappings");

            migrationBuilder.AlterColumn<int>(
                name: "MerchantRecordId",
                table: "MerchantValidationResponseMappings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MerchantRecordId",
                table: "MerchantPaymentResponseMappings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MerchantPaymentResponseMappings_Merchants_MerchantRecordId",
                table: "MerchantPaymentResponseMappings",
                column: "MerchantRecordId",
                principalTable: "Merchants",
                principalColumn: "RecordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MerchantValidationResponseMappings_Merchants_MerchantRecordId",
                table: "MerchantValidationResponseMappings",
                column: "MerchantRecordId",
                principalTable: "Merchants",
                principalColumn: "RecordId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MerchantPaymentResponseMappings_Merchants_MerchantRecordId",
                table: "MerchantPaymentResponseMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_MerchantValidationResponseMappings_Merchants_MerchantRecordId",
                table: "MerchantValidationResponseMappings");

            migrationBuilder.AlterColumn<int>(
                name: "MerchantRecordId",
                table: "MerchantValidationResponseMappings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MerchantConfigRecordId",
                table: "MerchantValidationResponseMappings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "MerchantRecordId",
                table: "MerchantPaymentResponseMappings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MerchantConfigRecordId",
                table: "MerchantPaymentResponseMappings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_MerchantPaymentResponseMappings_Merchants_MerchantRecordId",
                table: "MerchantPaymentResponseMappings",
                column: "MerchantRecordId",
                principalTable: "Merchants",
                principalColumn: "RecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_MerchantValidationResponseMappings_Merchants_MerchantRecordId",
                table: "MerchantValidationResponseMappings",
                column: "MerchantRecordId",
                principalTable: "Merchants",
                principalColumn: "RecordId");
        }
    }
}
