using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HrManagement.EF.Migrations
{
    /// <inheritdoc />
    public partial class FireHire : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComeLates_Employees_EmployeeId",
                table: "ComeLates");

            migrationBuilder.DropForeignKey(
                name: "FK_Disattends_Employees_EmployeeId",
                table: "Disattends");

            migrationBuilder.DropForeignKey(
                name: "FK_Discounts_Employees_EmployeeId",
                table: "Discounts");

            migrationBuilder.DropForeignKey(
                name: "FK_DisRegisters_Employees_EmployeeId",
                table: "DisRegisters");

            migrationBuilder.DropForeignKey(
                name: "FK_ExtraTimes_Employees_EmployeeId",
                table: "ExtraTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_Ponus_Employees_EmployeeId",
                table: "Ponus");

            migrationBuilder.DropForeignKey(
                name: "FK_WentEarlys_Employees_EmployeeId",
                table: "WentEarlys");

            migrationBuilder.DropIndex(
                name: "IX_WentEarlys_EmployeeId",
                table: "WentEarlys");

            migrationBuilder.DropIndex(
                name: "IX_Ponus_EmployeeId",
                table: "Ponus");

            migrationBuilder.DropIndex(
                name: "IX_ExtraTimes_EmployeeId",
                table: "ExtraTimes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_DisRegisters_EmployeeId",
                table: "DisRegisters");

            migrationBuilder.DropIndex(
                name: "IX_Discounts_EmployeeId",
                table: "Discounts");

            migrationBuilder.DropIndex(
                name: "IX_Disattends_EmployeeId",
                table: "Disattends");

            migrationBuilder.DropIndex(
                name: "IX_ComeLates_EmployeeId",
                table: "ComeLates");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "WentEarlys");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Ponus");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "ExtraTimes");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Firedate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "HiredDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "DisRegisters");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Disattends");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "ComeLates");

            migrationBuilder.RenameColumn(
                name: "MasterId",
                table: "WentEarlys",
                newName: "MasterIDPerson");

            migrationBuilder.RenameColumn(
                name: "MasterId",
                table: "ExtraTimes",
                newName: "MasterIDPerson");

            migrationBuilder.RenameColumn(
                name: "MasterId",
                table: "Employees",
                newName: "MasterIDPerson");

            migrationBuilder.RenameColumn(
                name: "MasterId",
                table: "Disattends",
                newName: "MasterIDPerson");

            migrationBuilder.RenameColumn(
                name: "MasterId",
                table: "ComeLates",
                newName: "MasterIDPerson");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeIDPerson",
                table: "WentEarlys",
                type: "nvarchar(14)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeIDPerson",
                table: "Ponus",
                type: "nvarchar(14)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeIDPerson",
                table: "ExtraTimes",
                type: "nvarchar(14)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "IDPerson",
                table: "Employees",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "InService",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeIDPerson",
                table: "DisRegisters",
                type: "nvarchar(14)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeIDPerson",
                table: "Discounts",
                type: "nvarchar(14)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeIDPerson",
                table: "Disattends",
                type: "nvarchar(14)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeIDPerson",
                table: "ComeLates",
                type: "nvarchar(14)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "IDPerson");

            migrationBuilder.CreateTable(
                name: "FireHireDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fired = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeIDPerson = table.Column<string>(type: "nvarchar(14)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireHireDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireHireDates_Employees_EmployeeIDPerson",
                        column: x => x.EmployeeIDPerson,
                        principalTable: "Employees",
                        principalColumn: "IDPerson",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WentEarlys_EmployeeIDPerson",
                table: "WentEarlys",
                column: "EmployeeIDPerson");

            migrationBuilder.CreateIndex(
                name: "IX_Ponus_EmployeeIDPerson",
                table: "Ponus",
                column: "EmployeeIDPerson");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraTimes_EmployeeIDPerson",
                table: "ExtraTimes",
                column: "EmployeeIDPerson");

            migrationBuilder.CreateIndex(
                name: "IX_DisRegisters_EmployeeIDPerson",
                table: "DisRegisters",
                column: "EmployeeIDPerson");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_EmployeeIDPerson",
                table: "Discounts",
                column: "EmployeeIDPerson");

            migrationBuilder.CreateIndex(
                name: "IX_Disattends_EmployeeIDPerson",
                table: "Disattends",
                column: "EmployeeIDPerson");

            migrationBuilder.CreateIndex(
                name: "IX_ComeLates_EmployeeIDPerson",
                table: "ComeLates",
                column: "EmployeeIDPerson");

            migrationBuilder.CreateIndex(
                name: "IX_FireHireDates_EmployeeIDPerson",
                table: "FireHireDates",
                column: "EmployeeIDPerson");

            migrationBuilder.AddForeignKey(
                name: "FK_ComeLates_Employees_EmployeeIDPerson",
                table: "ComeLates",
                column: "EmployeeIDPerson",
                principalTable: "Employees",
                principalColumn: "IDPerson",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disattends_Employees_EmployeeIDPerson",
                table: "Disattends",
                column: "EmployeeIDPerson",
                principalTable: "Employees",
                principalColumn: "IDPerson",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Discounts_Employees_EmployeeIDPerson",
                table: "Discounts",
                column: "EmployeeIDPerson",
                principalTable: "Employees",
                principalColumn: "IDPerson",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DisRegisters_Employees_EmployeeIDPerson",
                table: "DisRegisters",
                column: "EmployeeIDPerson",
                principalTable: "Employees",
                principalColumn: "IDPerson",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraTimes_Employees_EmployeeIDPerson",
                table: "ExtraTimes",
                column: "EmployeeIDPerson",
                principalTable: "Employees",
                principalColumn: "IDPerson",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ponus_Employees_EmployeeIDPerson",
                table: "Ponus",
                column: "EmployeeIDPerson",
                principalTable: "Employees",
                principalColumn: "IDPerson",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WentEarlys_Employees_EmployeeIDPerson",
                table: "WentEarlys",
                column: "EmployeeIDPerson",
                principalTable: "Employees",
                principalColumn: "IDPerson",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComeLates_Employees_EmployeeIDPerson",
                table: "ComeLates");

            migrationBuilder.DropForeignKey(
                name: "FK_Disattends_Employees_EmployeeIDPerson",
                table: "Disattends");

            migrationBuilder.DropForeignKey(
                name: "FK_Discounts_Employees_EmployeeIDPerson",
                table: "Discounts");

            migrationBuilder.DropForeignKey(
                name: "FK_DisRegisters_Employees_EmployeeIDPerson",
                table: "DisRegisters");

            migrationBuilder.DropForeignKey(
                name: "FK_ExtraTimes_Employees_EmployeeIDPerson",
                table: "ExtraTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_Ponus_Employees_EmployeeIDPerson",
                table: "Ponus");

            migrationBuilder.DropForeignKey(
                name: "FK_WentEarlys_Employees_EmployeeIDPerson",
                table: "WentEarlys");

            migrationBuilder.DropTable(
                name: "FireHireDates");

            migrationBuilder.DropIndex(
                name: "IX_WentEarlys_EmployeeIDPerson",
                table: "WentEarlys");

            migrationBuilder.DropIndex(
                name: "IX_Ponus_EmployeeIDPerson",
                table: "Ponus");

            migrationBuilder.DropIndex(
                name: "IX_ExtraTimes_EmployeeIDPerson",
                table: "ExtraTimes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_DisRegisters_EmployeeIDPerson",
                table: "DisRegisters");

            migrationBuilder.DropIndex(
                name: "IX_Discounts_EmployeeIDPerson",
                table: "Discounts");

            migrationBuilder.DropIndex(
                name: "IX_Disattends_EmployeeIDPerson",
                table: "Disattends");

            migrationBuilder.DropIndex(
                name: "IX_ComeLates_EmployeeIDPerson",
                table: "ComeLates");

            migrationBuilder.DropColumn(
                name: "EmployeeIDPerson",
                table: "WentEarlys");

            migrationBuilder.DropColumn(
                name: "EmployeeIDPerson",
                table: "Ponus");

            migrationBuilder.DropColumn(
                name: "EmployeeIDPerson",
                table: "ExtraTimes");

            migrationBuilder.DropColumn(
                name: "InService",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeIDPerson",
                table: "DisRegisters");

            migrationBuilder.DropColumn(
                name: "EmployeeIDPerson",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "EmployeeIDPerson",
                table: "Disattends");

            migrationBuilder.DropColumn(
                name: "EmployeeIDPerson",
                table: "ComeLates");

            migrationBuilder.RenameColumn(
                name: "MasterIDPerson",
                table: "WentEarlys",
                newName: "MasterId");

            migrationBuilder.RenameColumn(
                name: "MasterIDPerson",
                table: "ExtraTimes",
                newName: "MasterId");

            migrationBuilder.RenameColumn(
                name: "MasterIDPerson",
                table: "Employees",
                newName: "MasterId");

            migrationBuilder.RenameColumn(
                name: "MasterIDPerson",
                table: "Disattends",
                newName: "MasterId");

            migrationBuilder.RenameColumn(
                name: "MasterIDPerson",
                table: "ComeLates",
                newName: "MasterId");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "WentEarlys",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Ponus",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "ExtraTimes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "IDPerson",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AddColumn<string>(
                name: "ID",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Firedate",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HiredDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "DisRegisters",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Discounts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Disattends",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "ComeLates",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_WentEarlys_EmployeeId",
                table: "WentEarlys",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ponus_EmployeeId",
                table: "Ponus",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraTimes_EmployeeId",
                table: "ExtraTimes",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DisRegisters_EmployeeId",
                table: "DisRegisters",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_EmployeeId",
                table: "Discounts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Disattends_EmployeeId",
                table: "Disattends",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ComeLates_EmployeeId",
                table: "ComeLates",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComeLates_Employees_EmployeeId",
                table: "ComeLates",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disattends_Employees_EmployeeId",
                table: "Disattends",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Discounts_Employees_EmployeeId",
                table: "Discounts",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DisRegisters_Employees_EmployeeId",
                table: "DisRegisters",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraTimes_Employees_EmployeeId",
                table: "ExtraTimes",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ponus_Employees_EmployeeId",
                table: "Ponus",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WentEarlys_Employees_EmployeeId",
                table: "WentEarlys",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
