using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sky.ERP.Infrastructure.Migrations
{
    public partial class AddFloor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "POS");

            migrationBuilder.CreateTable(
                name: "Floors",
                schema: "POS",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    imageurl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    clientid = table.Column<long>(type: "bigint", nullable: false),
                    branchid = table.Column<long>(type: "bigint", nullable: false),
                    isremoved = table.Column<bool>(type: "bit", nullable: false),
                    createby = table.Column<long>(type: "bigint", nullable: false),
                    updatedby = table.Column<long>(type: "bigint", nullable: true),
                    createdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_floors", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "id",
                keyValue: 1L,
                column: "clientid",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "id",
                keyValue: 1L,
                column: "clientid",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "id",
                keyValue: 2L,
                column: "clientid",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "id",
                keyValue: 3L,
                column: "clientid",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "id",
                keyValue: 4L,
                column: "clientid",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "id",
                keyValue: 1L,
                column: "clientid",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "id",
                keyValue: 2L,
                column: "clientid",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "id",
                keyValue: 3L,
                column: "clientid",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "id",
                keyValue: 4L,
                column: "clientid",
                value: 1L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Floors",
                schema: "POS");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "id",
                keyValue: 1L,
                column: "clientid",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "id",
                keyValue: 1L,
                column: "clientid",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "id",
                keyValue: 2L,
                column: "clientid",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "id",
                keyValue: 3L,
                column: "clientid",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "id",
                keyValue: 4L,
                column: "clientid",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "id",
                keyValue: 1L,
                column: "clientid",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "id",
                keyValue: 2L,
                column: "clientid",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "id",
                keyValue: 3L,
                column: "clientid",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "id",
                keyValue: 4L,
                column: "clientid",
                value: 0L);
        }
    }
}
