using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HrManagement.EF.Migrations
{
    /// <inheritdoc />
    public partial class asd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComeLates_Discounts_discountId",
                table: "ComeLates");

            migrationBuilder.DropForeignKey(
                name: "FK_DisRegisters_Discounts_discountId",
                table: "DisRegisters");

            migrationBuilder.DropForeignKey(
                name: "FK_ExtraTimes_Ponus_ponusId",
                table: "ExtraTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_WentEarlys_Discounts_discountId",
                table: "WentEarlys");

            migrationBuilder.DropIndex(
                name: "IX_WentEarlys_discountId",
                table: "WentEarlys");

            migrationBuilder.DropIndex(
                name: "IX_ExtraTimes_ponusId",
                table: "ExtraTimes");

            migrationBuilder.DropIndex(
                name: "IX_DisRegisters_discountId",
                table: "DisRegisters");

            migrationBuilder.DropIndex(
                name: "IX_ComeLates_discountId",
                table: "ComeLates");

            migrationBuilder.AlterColumn<string>(
                name: "discountId",
                table: "WentEarlys",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ponusId",
                table: "ExtraTimes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "discountId",
                table: "DisRegisters",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "discountId",
                table: "Disattends",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Went",
                table: "Days",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Attend",
                table: "Days",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "discountId",
                table: "ComeLates",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_WentEarlys_discountId",
                table: "WentEarlys",
                column: "discountId",
                unique: true,
                filter: "[discountId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraTimes_ponusId",
                table: "ExtraTimes",
                column: "ponusId",
                unique: true,
                filter: "[ponusId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DisRegisters_discountId",
                table: "DisRegisters",
                column: "discountId",
                unique: true,
                filter: "[discountId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ComeLates_discountId",
                table: "ComeLates",
                column: "discountId",
                unique: true,
                filter: "[discountId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ComeLates_Discounts_discountId",
                table: "ComeLates",
                column: "discountId",
                principalTable: "Discounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DisRegisters_Discounts_discountId",
                table: "DisRegisters",
                column: "discountId",
                principalTable: "Discounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraTimes_Ponus_ponusId",
                table: "ExtraTimes",
                column: "ponusId",
                principalTable: "Ponus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WentEarlys_Discounts_discountId",
                table: "WentEarlys",
                column: "discountId",
                principalTable: "Discounts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComeLates_Discounts_discountId",
                table: "ComeLates");

            migrationBuilder.DropForeignKey(
                name: "FK_DisRegisters_Discounts_discountId",
                table: "DisRegisters");

            migrationBuilder.DropForeignKey(
                name: "FK_ExtraTimes_Ponus_ponusId",
                table: "ExtraTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_WentEarlys_Discounts_discountId",
                table: "WentEarlys");

            migrationBuilder.DropIndex(
                name: "IX_WentEarlys_discountId",
                table: "WentEarlys");

            migrationBuilder.DropIndex(
                name: "IX_ExtraTimes_ponusId",
                table: "ExtraTimes");

            migrationBuilder.DropIndex(
                name: "IX_DisRegisters_discountId",
                table: "DisRegisters");

            migrationBuilder.DropIndex(
                name: "IX_ComeLates_discountId",
                table: "ComeLates");

            migrationBuilder.AlterColumn<string>(
                name: "discountId",
                table: "WentEarlys",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ponusId",
                table: "ExtraTimes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "discountId",
                table: "DisRegisters",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "discountId",
                table: "Disattends",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Went",
                table: "Days",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Attend",
                table: "Days",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "discountId",
                table: "ComeLates",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WentEarlys_discountId",
                table: "WentEarlys",
                column: "discountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExtraTimes_ponusId",
                table: "ExtraTimes",
                column: "ponusId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DisRegisters_discountId",
                table: "DisRegisters",
                column: "discountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComeLates_discountId",
                table: "ComeLates",
                column: "discountId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ComeLates_Discounts_discountId",
                table: "ComeLates",
                column: "discountId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DisRegisters_Discounts_discountId",
                table: "DisRegisters",
                column: "discountId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraTimes_Ponus_ponusId",
                table: "ExtraTimes",
                column: "ponusId",
                principalTable: "Ponus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WentEarlys_Discounts_discountId",
                table: "WentEarlys",
                column: "discountId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
