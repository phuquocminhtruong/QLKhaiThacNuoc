using Microsoft.EntityFrameworkCore.Migrations;

namespace DOLPHIN.Model.Migrations
{
    public partial class UpdateTableCongTrinhKhaiThac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CongTrinhKhaiThac_CanBo_MaCanBoQuanLy",
                table: "CongTrinhKhaiThac");

            migrationBuilder.DropForeignKey(
                name: "FK_CongTrinhKhaiThac_ToTrinh_MaGiayPhep",
                table: "CongTrinhKhaiThac");

            migrationBuilder.DropColumn(
                name: "MaViTri",
                table: "CongTrinhKhaiThac");

            migrationBuilder.AlterColumn<int>(
                name: "MaGiayPhep",
                table: "CongTrinhKhaiThac",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaCanBoQuanLy",
                table: "CongTrinhKhaiThac",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CongTrinhKhaiThac_CanBo_MaCanBoQuanLy",
                table: "CongTrinhKhaiThac",
                column: "MaCanBoQuanLy",
                principalTable: "CanBo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CongTrinhKhaiThac_ToTrinh_MaGiayPhep",
                table: "CongTrinhKhaiThac",
                column: "MaGiayPhep",
                principalTable: "ToTrinh",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CongTrinhKhaiThac_CanBo_MaCanBoQuanLy",
                table: "CongTrinhKhaiThac");

            migrationBuilder.DropForeignKey(
                name: "FK_CongTrinhKhaiThac_ToTrinh_MaGiayPhep",
                table: "CongTrinhKhaiThac");

            migrationBuilder.AlterColumn<int>(
                name: "MaGiayPhep",
                table: "CongTrinhKhaiThac",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MaCanBoQuanLy",
                table: "CongTrinhKhaiThac",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "MaViTri",
                table: "CongTrinhKhaiThac",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CongTrinhKhaiThac_CanBo_MaCanBoQuanLy",
                table: "CongTrinhKhaiThac",
                column: "MaCanBoQuanLy",
                principalTable: "CanBo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CongTrinhKhaiThac_ToTrinh_MaGiayPhep",
                table: "CongTrinhKhaiThac",
                column: "MaGiayPhep",
                principalTable: "ToTrinh",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
