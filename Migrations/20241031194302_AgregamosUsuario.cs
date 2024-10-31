using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roticeria3ero.Migrations
{
    /// <inheritdoc />
    public partial class AgregamosUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 31, 16, 43, 0, 764, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 10, 31, 16, 43, 0, 764, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 10, 31, 16, 43, 0, 764, DateTimeKind.Local).AddTicks(4005));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 29, 22, 11, 38, 900, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 10, 29, 22, 11, 38, 900, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "Pedidos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 10, 29, 22, 11, 38, 900, DateTimeKind.Local).AddTicks(9508));
        }
    }
}
