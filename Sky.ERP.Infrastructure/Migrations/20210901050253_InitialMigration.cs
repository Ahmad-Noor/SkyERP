using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sky.ERP.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    street = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    line2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cityid = table.Column<long>(type: "bigint", nullable: true),
                    stateid = table.Column<long>(type: "bigint", nullable: true),
                    postalcode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    isphysical = table.Column<bool>(type: "bit", nullable: true),
                    isshipping = table.Column<bool>(type: "bit", nullable: true),
                    isbilling = table.Column<bool>(type: "bit", nullable: true),
                    isactive = table.Column<bool>(type: "bit", nullable: true),
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
                    table.PrimaryKey("pk_addresses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    logourl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    showlogo = table.Column<bool>(type: "bit", nullable: true),
                    addressid = table.Column<int>(type: "int", nullable: true),
                    contactid = table.Column<int>(type: "int", nullable: true),
                    commercialno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    siteurl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    defaultcurrencyid = table.Column<long>(type: "bigint", nullable: true),
                    defaultinventoryid = table.Column<long>(type: "bigint", nullable: true),
                    defaultcostcenterid = table.Column<long>(type: "bigint", nullable: true),
                    accpurchasesid = table.Column<long>(type: "bigint", nullable: true),
                    accsuppliersid = table.Column<long>(type: "bigint", nullable: true),
                    acccashid = table.Column<long>(type: "bigint", nullable: true),
                    accpurchasesreturnsid = table.Column<long>(type: "bigint", nullable: true),
                    accsalestaxonpurchasesid = table.Column<long>(type: "bigint", nullable: true),
                    accdiscountacquiredid = table.Column<long>(type: "bigint", nullable: true),
                    accsalesid = table.Column<long>(type: "bigint", nullable: true),
                    accinventoryid = table.Column<long>(type: "bigint", nullable: true),
                    accsalescostid = table.Column<long>(type: "bigint", nullable: true),
                    inventoryaccountingtypes = table.Column<int>(type: "int", nullable: true),
                    systemtype = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("pk_branches", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    rate = table.Column<float>(type: "real", nullable: true),
                    symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("pk_currencies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    isactive = table.Column<bool>(type: "bit", nullable: true),
                    addressid = table.Column<long>(type: "bigint", nullable: true),
                    contactid = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("pk_customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("pk_departments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    firstname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    fathername = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    mothername = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    imageurl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    machinecode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    gender = table.Column<int>(type: "int", nullable: true),
                    religionid = table.Column<int>(type: "int", nullable: true),
                    dateofbirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    placeofbirth = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    militaryservice = table.Column<int>(type: "int", nullable: true),
                    materialstate = table.Column<int>(type: "int", nullable: true),
                    addressid = table.Column<long>(type: "bigint", nullable: true),
                    contactid = table.Column<long>(type: "bigint", nullable: true),
                    jobid = table.Column<long>(type: "bigint", nullable: true),
                    departmentid = table.Column<long>(type: "bigint", nullable: true),
                    managementid = table.Column<long>(type: "bigint", nullable: true),
                    workstatusid = table.Column<long>(type: "bigint", nullable: true),
                    managerid = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("pk_employees", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GLChart",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    name = table.Column<long>(type: "bigint", maxLength: 150, nullable: false),
                    parentid = table.Column<long>(type: "bigint", nullable: false),
                    accountorder = table.Column<int>(type: "int", nullable: false),
                    finalaccountid = table.Column<long>(type: "bigint", nullable: false),
                    currencyid = table.Column<long>(type: "bigint", nullable: false),
                    accountnature = table.Column<int>(type: "int", nullable: false),
                    accounttype = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("pk_glchart", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProductMaterials",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productid = table.Column<long>(type: "bigint", nullable: false),
                    productmaterialid = table.Column<long>(type: "bigint", nullable: false),
                    quantity = table.Column<float>(type: "real", nullable: false),
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
                    table.PrimaryKey("pk_productmaterials", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    imageurl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    categoryid = table.Column<int>(type: "int", nullable: false),
                    kitchenid = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    iskitchenprint = table.Column<bool>(type: "bit", nullable: false),
                    sortid = table.Column<int>(type: "int", nullable: false),
                    colorargb = table.Column<int>(type: "int", nullable: false),
                    producttype = table.Column<int>(type: "int", nullable: false),
                    barcode = table.Column<int>(type: "int", maxLength: 150, nullable: false),
                    defaultsupplier = table.Column<int>(type: "int", nullable: false),
                    hasseries = table.Column<bool>(type: "bit", nullable: true),
                    ishascolors = table.Column<bool>(type: "bit", nullable: true),
                    ishassizes = table.Column<bool>(type: "bit", nullable: true),
                    ishasexpirdate = table.Column<bool>(type: "bit", nullable: true),
                    ishaswarranty = table.Column<bool>(type: "bit", nullable: true),
                    isactive = table.Column<bool>(type: "bit", nullable: true),
                    demandlimit = table.Column<int>(type: "int", nullable: false),
                    monthlysalestarget = table.Column<int>(type: "int", nullable: false),
                    intervalrecession = table.Column<int>(type: "int", nullable: false),
                    highestrate = table.Column<int>(type: "int", nullable: false),
                    attentionexpirdate = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("pk_products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSizes",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productid = table.Column<long>(type: "bigint", nullable: false),
                    sizeid = table.Column<long>(type: "bigint", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
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
                    table.PrimaryKey("pk_productsizes", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "id", "acccashid", "accdiscountacquiredid", "accinventoryid", "accpurchasesid", "accpurchasesreturnsid", "accsalescostid", "accsalesid", "accsalestaxonpurchasesid", "accsuppliersid", "addressid", "branchid", "code", "commercialno", "contactid", "createby", "createdate", "defaultcostcenterid", "defaultcurrencyid", "defaultinventoryid", "inventoryaccountingtypes", "isremoved", "logourl", "name", "note", "showlogo", "siteurl", "systemtype", "updatedby", "updateddate" },
                values: new object[] { 1L, null, null, null, null, null, null, null, null, null, null, 0L, "001", null, null, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, null, "Main Branch", null, null, null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "GLChart");

            migrationBuilder.DropTable(
                name: "ProductMaterials");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductSizes");
        }
    }
}
