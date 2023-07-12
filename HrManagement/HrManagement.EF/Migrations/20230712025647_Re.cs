using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HrManagement.EF.Migrations
{
    /// <inheritdoc />
    public partial class Re : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateWent",
                table: "WentEarlys",
                newName: "DayId");

            migrationBuilder.AddColumn<string>(
                name: "discountId",
                table: "WentEarlys",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "extraTimeId",
                table: "Ponus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DayId",
                table: "ExtraTimes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ponusId",
                table: "ExtraTimes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "stopRegister",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DayId",
                table: "DisRegisters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "discountId",
                table: "DisRegisters",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "comeLateId",
                table: "Discounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "disAttendId",
                table: "Discounts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "disRegisterId",
                table: "Discounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "wentEarlyId",
                table: "Discounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DayId",
                table: "Disattends",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "discountId",
                table: "Disattends",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DayId",
                table: "ComeLates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "discountId",
                table: "ComeLates",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Id = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Attend = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Went = table.Column<DateTime>(type: "datetime2", nullable: false),
                    comeLateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    disAttendId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    disRegisterId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    extraTimeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wentEarlyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeIDPerson = table.Column<string>(type: "nvarchar(14)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Days_Employees_EmployeeIDPerson",
                        column: x => x.EmployeeIDPerson,
                        principalTable: "Employees",
                        principalColumn: "IDPerson");
                });

            migrationBuilder.CreateTable(
                name: "InformationAtendAndLeaving",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attend = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Leaving = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationAtendAndLeaving", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WentEarlys_DayId",
                table: "WentEarlys",
                column: "DayId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WentEarlys_discountId",
                table: "WentEarlys",
                column: "discountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExtraTimes_DayId",
                table: "ExtraTimes",
                column: "DayId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExtraTimes_ponusId",
                table: "ExtraTimes",
                column: "ponusId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DisRegisters_DayId",
                table: "DisRegisters",
                column: "DayId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DisRegisters_discountId",
                table: "DisRegisters",
                column: "discountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_disAttendId",
                table: "Discounts",
                column: "disAttendId",
                unique: true,
                filter: "[disAttendId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Disattends_DayId",
                table: "Disattends",
                column: "DayId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComeLates_DayId",
                table: "ComeLates",
                column: "DayId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComeLates_discountId",
                table: "ComeLates",
                column: "discountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Days_EmployeeIDPerson",
                table: "Days",
                column: "EmployeeIDPerson");

            migrationBuilder.AddForeignKey(
                name: "FK_ComeLates_Days_DayId",
                table: "ComeLates",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ComeLates_Discounts_discountId",
                table: "ComeLates",
                column: "discountId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Disattends_Days_DayId",
                table: "Disattends",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Discounts_Disattends_disAttendId",
                table: "Discounts",
                column: "disAttendId",
                principalTable: "Disattends",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DisRegisters_Days_DayId",
                table: "DisRegisters",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_DisRegisters_Discounts_discountId",
                table: "DisRegisters",
                column: "discountId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraTimes_Days_DayId",
                table: "ExtraTimes",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraTimes_Ponus_ponusId",
                table: "ExtraTimes",
                column: "ponusId",
                principalTable: "Ponus",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_WentEarlys_Days_DayId",
                table: "WentEarlys",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_WentEarlys_Discounts_discountId",
                table: "WentEarlys",
                column: "discountId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComeLates_Days_DayId",
                table: "ComeLates");

            migrationBuilder.DropForeignKey(
                name: "FK_ComeLates_Discounts_discountId",
                table: "ComeLates");

            migrationBuilder.DropForeignKey(
                name: "FK_Disattends_Days_DayId",
                table: "Disattends");

            migrationBuilder.DropForeignKey(
                name: "FK_Discounts_Disattends_disAttendId",
                table: "Discounts");

            migrationBuilder.DropForeignKey(
                name: "FK_DisRegisters_Days_DayId",
                table: "DisRegisters");

            migrationBuilder.DropForeignKey(
                name: "FK_DisRegisters_Discounts_discountId",
                table: "DisRegisters");

            migrationBuilder.DropForeignKey(
                name: "FK_ExtraTimes_Days_DayId",
                table: "ExtraTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_ExtraTimes_Ponus_ponusId",
                table: "ExtraTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_WentEarlys_Days_DayId",
                table: "WentEarlys");

            migrationBuilder.DropForeignKey(
                name: "FK_WentEarlys_Discounts_discountId",
                table: "WentEarlys");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "InformationAtendAndLeaving");

            migrationBuilder.DropIndex(
                name: "IX_WentEarlys_DayId",
                table: "WentEarlys");

            migrationBuilder.DropIndex(
                name: "IX_WentEarlys_discountId",
                table: "WentEarlys");

            migrationBuilder.DropIndex(
                name: "IX_ExtraTimes_DayId",
                table: "ExtraTimes");

            migrationBuilder.DropIndex(
                name: "IX_ExtraTimes_ponusId",
                table: "ExtraTimes");

            migrationBuilder.DropIndex(
                name: "IX_DisRegisters_DayId",
                table: "DisRegisters");

            migrationBuilder.DropIndex(
                name: "IX_DisRegisters_discountId",
                table: "DisRegisters");

            migrationBuilder.DropIndex(
                name: "IX_Discounts_disAttendId",
                table: "Discounts");

            migrationBuilder.DropIndex(
                name: "IX_Disattends_DayId",
                table: "Disattends");

            migrationBuilder.DropIndex(
                name: "IX_ComeLates_DayId",
                table: "ComeLates");

            migrationBuilder.DropIndex(
                name: "IX_ComeLates_discountId",
                table: "ComeLates");

            migrationBuilder.DropColumn(
                name: "discountId",
                table: "WentEarlys");

            migrationBuilder.DropColumn(
                name: "extraTimeId",
                table: "Ponus");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "ExtraTimes");

            migrationBuilder.DropColumn(
                name: "ponusId",
                table: "ExtraTimes");

            migrationBuilder.DropColumn(
                name: "stopRegister",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "DisRegisters");

            migrationBuilder.DropColumn(
                name: "discountId",
                table: "DisRegisters");

            migrationBuilder.DropColumn(
                name: "comeLateId",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "disAttendId",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "disRegisterId",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "wentEarlyId",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "Disattends");

            migrationBuilder.DropColumn(
                name: "discountId",
                table: "Disattends");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "ComeLates");

            migrationBuilder.DropColumn(
                name: "discountId",
                table: "ComeLates");

            migrationBuilder.RenameColumn(
                name: "DayId",
                table: "WentEarlys",
                newName: "DateWent");
        }
    }
}
