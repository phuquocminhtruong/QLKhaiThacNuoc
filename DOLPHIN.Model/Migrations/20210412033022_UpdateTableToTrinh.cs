using Microsoft.EntityFrameworkCore.Migrations;

namespace DOLPHIN.Model.Migrations
{
    public partial class UpdateTableToTrinh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaViTriKhaiThac",
                table: "ToTrinh");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaViTriKhaiThac",
                table: "ToTrinh",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
