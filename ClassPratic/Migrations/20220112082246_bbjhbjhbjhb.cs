using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassPratic.Migrations
{
    public partial class bbjhbjhbjhb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomUserId",
                table: "Employes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomUserId",
                table: "Employes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
