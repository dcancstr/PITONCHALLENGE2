using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PITON.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ETransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    TransactionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionStatus = table.Column<bool>(type: "bit", nullable: false),
                    TransactionTypes = table.Column<bool>(type: "bit", nullable: false),
                    Rrn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvisionNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardNumberMasked = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardHolderFullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ETransactions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ETransactions");
        }
    }
}
