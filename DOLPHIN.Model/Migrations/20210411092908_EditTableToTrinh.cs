using Microsoft.EntityFrameworkCore.Migrations;

namespace DOLPHIN.Model.Migrations
{
    public partial class EditTableToTrinh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToTrinh_DonViHanhChinh_MaDonViHanhChinh",
                table: "ToTrinh");

            migrationBuilder.DropForeignKey(
                name: "FK_ToTrinh_QuanTrac_MaQuanTrac",
                table: "ToTrinh");

            migrationBuilder.DropForeignKey(
                name: "FK_ToTrinh_ToChuc_MaToChuc",
                table: "ToTrinh");

            migrationBuilder.AlterColumn<int>(
                name: "MaToChuc",
                table: "ToTrinh",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaQuanTrac",
                table: "ToTrinh",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaDonViHanhChinh",
                table: "ToTrinh",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ToTrinh_DonViHanhChinh_MaDonViHanhChinh",
                table: "ToTrinh",
                column: "MaDonViHanhChinh",
                principalTable: "DonViHanhChinh",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToTrinh_QuanTrac_MaQuanTrac",
                table: "ToTrinh",
                column: "MaQuanTrac",
                principalTable: "QuanTrac",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToTrinh_ToChuc_MaToChuc",
                table: "ToTrinh",
                column: "MaToChuc",
                principalTable: "ToChuc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToTrinh_DonViHanhChinh_MaDonViHanhChinh",
                table: "ToTrinh");

            migrationBuilder.DropForeignKey(
                name: "FK_ToTrinh_QuanTrac_MaQuanTrac",
                table: "ToTrinh");

            migrationBuilder.DropForeignKey(
                name: "FK_ToTrinh_ToChuc_MaToChuc",
                table: "ToTrinh");

            migrationBuilder.AlterColumn<int>(
                name: "MaToChuc",
                table: "ToTrinh",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MaQuanTrac",
                table: "ToTrinh",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MaDonViHanhChinh",
                table: "ToTrinh",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

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
    }
}
