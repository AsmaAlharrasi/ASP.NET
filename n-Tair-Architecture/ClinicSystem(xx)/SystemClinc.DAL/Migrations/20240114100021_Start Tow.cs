using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemClinc.DAL.Migrations
{
    public partial class StartTow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_AdminID",
                table: "Appointments",
                column: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Admin_AdminID",
                table: "Appointments",
                column: "AdminID",
                principalTable: "Admin",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Admin_AdminID",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_AdminID",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "Appointments");
        }
    }
}
