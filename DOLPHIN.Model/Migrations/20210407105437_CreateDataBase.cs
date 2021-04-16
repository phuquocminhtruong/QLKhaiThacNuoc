using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DOLPHIN.Model.Migrations
{
    public partial class CreateDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BienBan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenBienBan = table.Column<string>(nullable: true),
                    NgayLapBienBan = table.Column<DateTime>(nullable: false),
                    MaToChucDaiDien = table.Column<int>(nullable: false),
                    ThongTinDonVi = table.Column<string>(nullable: true),
                    NgayThucHienQuyDinh = table.Column<DateTime>(nullable: false),
                    HienTrang = table.Column<string>(nullable: true),
                    NhanXet = table.Column<string>(nullable: true),
                    YKienDonVi = table.Column<string>(nullable: true),
                    SoLanCapNhat = table.Column<int>(nullable: false),
                    NgayBanHanh = table.Column<DateTime>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BienBan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CanBo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenCanBo = table.Column<string>(nullable: false),
                    DonVi = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    SoDienThoai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanBo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CongTrinhKhaiThac",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenCongTrinh = table.Column<string>(nullable: true),
                    LoaiCongTrinh = table.Column<string>(nullable: true),
                    MaViTri = table.Column<int>(nullable: false),
                    MaCanBoQuanLy = table.Column<int>(nullable: false),
                    NgayThucHien = table.Column<DateTime>(nullable: false),
                    ThoiGianDuKien = table.Column<DateTime>(nullable: false),
                    MaGiayPhep = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongTrinhKhaiThac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DonViHanhChinh",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenDonViHanhChinh = table.Column<string>(nullable: false),
                    ToaDo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonViHanhChinh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HoSo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenHoSo = table.Column<string>(nullable: true),
                    KhoiLuong = table.Column<int>(nullable: false),
                    NoiDung = table.Column<string>(nullable: true),
                    MaToChuc = table.Column<int>(nullable: false),
                    NgayThucHienQuyDinh = table.Column<DateTime>(nullable: false),
                    NgayThucHienThucTe = table.Column<DateTime>(nullable: false),
                    SoLanCapNhat = table.Column<int>(nullable: false),
                    NgayBanHanh = table.Column<DateTime>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoSo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HoSoQuet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenHoSo = table.Column<string>(nullable: true),
                    MaCanBoThucHien = table.Column<int>(nullable: false),
                    NoiDung = table.Column<string>(nullable: true),
                    NgayThucHien = table.Column<DateTime>(nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoSoQuet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiChiPhi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenLoaiChiPhi = table.Column<string>(nullable: true),
                    SoTien = table.Column<int>(nullable: false),
                    NgayBanHanh = table.Column<DateTime>(nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiChiPhi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetaData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenFile = table.Column<string>(nullable: true),
                    NoiDung = table.Column<string>(nullable: true),
                    NgayThucHien = table.Column<DateTime>(nullable: false),
                    NgayCapNhat = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuanTrac",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MucNuocTinh = table.Column<int>(nullable: false),
                    MucNuocDong = table.Column<int>(nullable: false),
                    LuuLuong = table.Column<int>(nullable: false),
                    ChatLuongNuoc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanTrac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoGiaHan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LuuLuong = table.Column<int>(nullable: false),
                    DuongKinh = table.Column<int>(nullable: false),
                    ToaDo = table.Column<string>(nullable: true),
                    ThoiGian = table.Column<DateTime>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoGiaHan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoHieu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenLoaiVanBan = table.Column<string>(nullable: true),
                    ChuVietTat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoHieu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThongBao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenThongBao = table.Column<string>(nullable: true),
                    NgayBanHanh = table.Column<DateTime>(nullable: false),
                    LuuLuongKhaiThac = table.Column<int>(nullable: false),
                    MaToChuc = table.Column<int>(nullable: false),
                    MaLoaiChiPhi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongBao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToChuc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenToChuc = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    SoDienThoai = table.Column<string>(nullable: true),
                    MaNhanVienQuanLy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToChuc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToTrinh",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenToTrinh = table.Column<string>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    MaToChuc = table.Column<int>(nullable: false),
                    MaDonViHanhChinh = table.Column<int>(nullable: false),
                    MucDichKhaiThac = table.Column<string>(nullable: true),
                    MaViTriKhaiThac = table.Column<int>(nullable: false),
                    TangChuaNuocKhaiThac = table.Column<int>(nullable: false),
                    SoGieng = table.Column<int>(nullable: false),
                    LuongNuocKhaiThac = table.Column<int>(nullable: false),
                    ThoiHanCapPhep = table.Column<DateTime>(nullable: false),
                    MaQuanTrac = table.Column<int>(nullable: false),
                    SoLanCapNhat = table.Column<int>(nullable: false),
                    NgayBanHanh = table.Column<DateTime>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToTrinh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoHieuSoGiaHan",
                columns: table => new
                {
                    MaSoHieu = table.Column<int>(nullable: false),
                    MaSoGiaHan = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoHieuSoGiaHan", x => new { x.MaSoHieu, x.MaSoGiaHan });
                    table.ForeignKey(
                        name: "FK_SoHieuSoGiaHan_SoGiaHan_MaSoGiaHan",
                        column: x => x.MaSoGiaHan,
                        principalTable: "SoGiaHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoHieuSoGiaHan_SoHieu_MaSoHieu",
                        column: x => x.MaSoHieu,
                        principalTable: "SoHieu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToChucSoGiaHan",
                columns: table => new
                {
                    MaToChuc = table.Column<int>(nullable: false),
                    MaSoGiaHan = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToChucSoGiaHan", x => new { x.MaToChuc, x.MaSoGiaHan });
                    table.ForeignKey(
                        name: "FK_ToChucSoGiaHan_SoGiaHan_MaSoGiaHan",
                        column: x => x.MaSoGiaHan,
                        principalTable: "SoGiaHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ToChucSoGiaHan_ToChuc_MaToChuc",
                        column: x => x.MaToChuc,
                        principalTable: "ToChuc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiayPhepSoGiaHan",
                columns: table => new
                {
                    MaGiayPhep = table.Column<int>(nullable: false),
                    MaSoGiaHan = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiayPhepSoGiaHan", x => new { x.MaGiayPhep, x.MaSoGiaHan });
                    table.ForeignKey(
                        name: "FK_GiayPhepSoGiaHan_ToTrinh_MaGiayPhep",
                        column: x => x.MaGiayPhep,
                        principalTable: "ToTrinh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GiayPhepSoGiaHan_SoGiaHan_MaSoGiaHan",
                        column: x => x.MaSoGiaHan,
                        principalTable: "SoGiaHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GiayPhepSoGiaHan_MaSoGiaHan",
                table: "GiayPhepSoGiaHan",
                column: "MaSoGiaHan");

            migrationBuilder.CreateIndex(
                name: "IX_SoHieuSoGiaHan_MaSoGiaHan",
                table: "SoHieuSoGiaHan",
                column: "MaSoGiaHan");

            migrationBuilder.CreateIndex(
                name: "IX_ToChucSoGiaHan_MaSoGiaHan",
                table: "ToChucSoGiaHan",
                column: "MaSoGiaHan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BienBan");

            migrationBuilder.DropTable(
                name: "CanBo");

            migrationBuilder.DropTable(
                name: "CongTrinhKhaiThac");

            migrationBuilder.DropTable(
                name: "DonViHanhChinh");

            migrationBuilder.DropTable(
                name: "GiayPhepSoGiaHan");

            migrationBuilder.DropTable(
                name: "HoSo");

            migrationBuilder.DropTable(
                name: "HoSoQuet");

            migrationBuilder.DropTable(
                name: "LoaiChiPhi");

            migrationBuilder.DropTable(
                name: "MetaData");

            migrationBuilder.DropTable(
                name: "QuanTrac");

            migrationBuilder.DropTable(
                name: "SoHieuSoGiaHan");

            migrationBuilder.DropTable(
                name: "ThongBao");

            migrationBuilder.DropTable(
                name: "ToChucSoGiaHan");

            migrationBuilder.DropTable(
                name: "ToTrinh");

            migrationBuilder.DropTable(
                name: "SoHieu");

            migrationBuilder.DropTable(
                name: "SoGiaHan");

            migrationBuilder.DropTable(
                name: "ToChuc");
        }
    }
}
