using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entregableNET.Migrations
{
    public partial class version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "tasks_id", "description", "completed", "title" },
                values: new object[] { 1, "test de prueba", true, "test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "tasks_id",
                keyValue: 1);
        }
    }
}
