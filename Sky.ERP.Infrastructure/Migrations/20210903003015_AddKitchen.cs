using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sky.ERP.Infrastructure.Migrations
{
    public partial class AddKitchen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ishaveprinter",
                schema: "POS",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "ishavescreen",
                schema: "POS",
                table: "Tables");

            migrationBuilder.CreateTable(
                name: "Kitchens",
                schema: "POS",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ishaveprinter = table.Column<bool>(type: "bit", nullable: true),
                    ishavescreen = table.Column<bool>(type: "bit", nullable: true),
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
                    table.PrimaryKey("pk_kitchens", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kitchens",
                schema: "POS");

            migrationBuilder.AddColumn<bool>(
                name: "ishaveprinter",
                schema: "POS",
                table: "Tables",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ishavescreen",
                schema: "POS",
                table: "Tables",
                type: "bit",
                nullable: true);
        }
    }
}
