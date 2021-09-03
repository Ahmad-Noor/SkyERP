using Microsoft.EntityFrameworkCore.Migrations;

namespace Sky.ERP.Infrastructure.Migrations
{
    public partial class AddClientIdInAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "clientid",
                table: "Units",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "clientid",
                table: "Sizes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "clientid",
                table: "ProductUnits",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "clientid",
                table: "ProductSizes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "clientid",
                table: "Products",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "clientid",
                table: "ProductMaterials",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "clientid",
                table: "GLChart",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "clientid",
                table: "Employees",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "clientid",
                table: "Departments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "clientid",
                table: "Customers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "clientid",
                table: "Currencies",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "clientid",
                table: "Branches",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "clientid",
                table: "Addresses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "clientid",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "clientid",
                table: "Sizes");

            migrationBuilder.DropColumn(
                name: "clientid",
                table: "ProductUnits");

            migrationBuilder.DropColumn(
                name: "clientid",
                table: "ProductSizes");

            migrationBuilder.DropColumn(
                name: "clientid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "clientid",
                table: "ProductMaterials");

            migrationBuilder.DropColumn(
                name: "clientid",
                table: "GLChart");

            migrationBuilder.DropColumn(
                name: "clientid",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "clientid",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "clientid",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "clientid",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "clientid",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "clientid",
                table: "Addresses");
        }
    }
}
