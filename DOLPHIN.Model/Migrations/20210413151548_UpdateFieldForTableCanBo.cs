using Microsoft.EntityFrameworkCore.Migrations;

namespace DOLPHIN.Model.Migrations
{
    public partial class UpdateFieldForTableCanBo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "CongTrinhKhaiThac",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "CanBo",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "CongTrinhKhaiThac");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "CanBo");
        }
    }
}
