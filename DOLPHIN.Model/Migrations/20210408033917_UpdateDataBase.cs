using Microsoft.EntityFrameworkCore.Migrations;

namespace DOLPHIN.Model.Migrations
{
    public partial class UpdateDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MaToChuc",
                table: "ToTrinh",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaQuanTrac",
                table: "ToTrinh",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaDonViHanhChinh",
                table: "ToTrinh",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaToChuc",
                table: "ThongBao",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaCanBoThucHien",
                table: "HoSoQuet",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaToChuc",
                table: "HoSo",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaGiayPhep",
                table: "CongTrinhKhaiThac",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaCanBoQuanLy",
                table: "CongTrinhKhaiThac",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaToChucDaiDien",
                table: "BienBan",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_ToTrinh_MaDonViHanhChinh",
                table: "ToTrinh",
                column: "MaDonViHanhChinh");

            migrationBuilder.CreateIndex(
                name: "IX_ToTrinh_MaQuanTrac",
                table: "ToTrinh",
                column: "MaQuanTrac");

            migrationBuilder.CreateIndex(
                name: "IX_ToTrinh_MaToChuc",
                table: "ToTrinh",
                column: "MaToChuc");

            migrationBuilder.CreateIndex(
                name: "IX_ThongBao_MaToChuc",
                table: "ThongBao",
                column: "MaToChuc");

            migrationBuilder.CreateIndex(
                name: "IX_HoSoQuet_MaCanBoThucHien",
                table: "HoSoQuet",
                column: "MaCanBoThucHien");

            migrationBuilder.CreateIndex(
                name: "IX_HoSo_MaToChuc",
                table: "HoSo",
                column: "MaToChuc");

            migrationBuilder.CreateIndex(
                name: "IX_CongTrinhKhaiThac_MaCanBoQuanLy",
                table: "CongTrinhKhaiThac",
                column: "MaCanBoQuanLy");

            migrationBuilder.CreateIndex(
                name: "IX_CongTrinhKhaiThac_MaGiayPhep",
                table: "CongTrinhKhaiThac",
                column: "MaGiayPhep");

            migrationBuilder.CreateIndex(
                name: "IX_BienBan_MaToChucDaiDien",
                table: "BienBan",
                column: "MaToChucDaiDien");

            migrationBuilder.AddForeignKey(
                name: "FK_BienBan_ToChuc_MaToChucDaiDien",
                table: "BienBan",
                column: "MaToChucDaiDien",
                principalTable: "ToChuc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_HoSo_ToChuc_MaToChuc",
                table: "HoSo",
                column: "MaToChuc",
                principalTable: "ToChuc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HoSoQuet_CanBo_MaCanBoThucHien",
                table: "HoSoQuet",
                column: "MaCanBoThucHien",
                principalTable: "CanBo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ThongBao_ToChuc_MaToChuc",
                table: "ThongBao",
                column: "MaToChuc",
                principalTable: "ToChuc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ToTrinh_DonViHanhChinh_MaDonViHanhChinh",
                table: "ToTrinh",
                column: "MaDonViHanhChinh",
                principalTable: "DonViHanhChinh",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ToTrinh_QuanTrac_MaQuanTrac",
                table: "ToTrinh",
                column: "MaQuanTrac",
                principalTable: "QuanTrac",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ToTrinh_ToChuc_MaToChuc",
                table: "ToTrinh",
                column: "MaToChuc",
                principalTable: "ToChuc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BienBan_ToChuc_MaToChucDaiDien",
                table: "BienBan");

            migrationBuilder.DropForeignKey(
                name: "FK_CongTrinhKhaiThac_CanBo_MaCanBoQuanLy",
                table: "CongTrinhKhaiThac");

            migrationBuilder.DropForeignKey(
                name: "FK_CongTrinhKhaiThac_ToTrinh_MaGiayPhep",
                table: "CongTrinhKhaiThac");

            migrationBuilder.DropForeignKey(
                name: "FK_HoSo_ToChuc_MaToChuc",
                table: "HoSo");

            migrationBuilder.DropForeignKey(
                name: "FK_HoSoQuet_CanBo_MaCanBoThucHien",
                table: "HoSoQuet");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongBao_ToChuc_MaToChuc",
                table: "ThongBao");

            migrationBuilder.DropForeignKey(
                name: "FK_ToTrinh_DonViHanhChinh_MaDonViHanhChinh",
                table: "ToTrinh");

            migrationBuilder.DropForeignKey(
                name: "FK_ToTrinh_QuanTrac_MaQuanTrac",
                table: "ToTrinh");

            migrationBuilder.DropForeignKey(
                name: "FK_ToTrinh_ToChuc_MaToChuc",
                table: "ToTrinh");

            migrationBuilder.DropIndex(
                name: "IX_ToTrinh_MaDonViHanhChinh",
                table: "ToTrinh");

            migrationBuilder.DropIndex(
                name: "IX_ToTrinh_MaQuanTrac",
                table: "ToTrinh");

            migrationBuilder.DropIndex(
                name: "IX_ToTrinh_MaToChuc",
                table: "ToTrinh");

            migrationBuilder.DropIndex(
                name: "IX_ThongBao_MaToChuc",
                table: "ThongBao");

            migrationBuilder.DropIndex(
                name: "IX_HoSoQuet_MaCanBoThucHien",
                table: "HoSoQuet");

            migrationBuilder.DropIndex(
                name: "IX_HoSo_MaToChuc",
                table: "HoSo");

            migrationBuilder.DropIndex(
                name: "IX_CongTrinhKhaiThac_MaCanBoQuanLy",
                table: "CongTrinhKhaiThac");

            migrationBuilder.DropIndex(
                name: "IX_CongTrinhKhaiThac_MaGiayPhep",
                table: "CongTrinhKhaiThac");

            migrationBuilder.DropIndex(
                name: "IX_BienBan_MaToChucDaiDien",
                table: "BienBan");

            migrationBuilder.AlterColumn<int>(
                name: "MaToChuc",
                table: "ToTrinh",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaQuanTrac",
                table: "ToTrinh",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaDonViHanhChinh",
                table: "ToTrinh",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaToChuc",
                table: "ThongBao",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaCanBoThucHien",
                table: "HoSoQuet",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaToChuc",
                table: "HoSo",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaGiayPhep",
                table: "CongTrinhKhaiThac",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaCanBoQuanLy",
                table: "CongTrinhKhaiThac",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaToChucDaiDien",
                table: "BienBan",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
