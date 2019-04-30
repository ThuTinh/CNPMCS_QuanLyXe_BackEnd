using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GSoft.AbpZeroTemplate.Migrations
{
    public partial class ThongTinSuaChuas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "congTyThuPhi",
                table: "PhiDuongBos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ghiChu",
                table: "PhiDuongBos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "loaiPhi",
                table: "PhiDuongBos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ngayCapNhat",
                table: "PhiDuongBos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ngayDongPhi",
                table: "PhiDuongBos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ngayHetHanDongPhi",
                table: "PhiDuongBos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "soTienThanhToan",
                table: "PhiDuongBos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "soXe",
                table: "PhiDuongBos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "thoiGianSuDung",
                table: "PhiDuongBos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ThongTinSuaChuas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    soXe = table.Column<string>(nullable: true),
                    ngaySuaChua = table.Column<string>(nullable: true),
                    ngayDuKienSuaXong = table.Column<string>(nullable: true),
                    chiPhiSuaChua = table.Column<string>(nullable: true),
                    noiDungSuaChuaThucTe = table.Column<string>(nullable: true),
                    trangThaiDuyet = table.Column<bool>(nullable: false),
                    ghiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinSuaChuas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThongTinSuaChuas");

            migrationBuilder.DropColumn(
                name: "congTyThuPhi",
                table: "PhiDuongBos");

            migrationBuilder.DropColumn(
                name: "ghiChu",
                table: "PhiDuongBos");

            migrationBuilder.DropColumn(
                name: "loaiPhi",
                table: "PhiDuongBos");

            migrationBuilder.DropColumn(
                name: "ngayCapNhat",
                table: "PhiDuongBos");

            migrationBuilder.DropColumn(
                name: "ngayDongPhi",
                table: "PhiDuongBos");

            migrationBuilder.DropColumn(
                name: "ngayHetHanDongPhi",
                table: "PhiDuongBos");

            migrationBuilder.DropColumn(
                name: "soTienThanhToan",
                table: "PhiDuongBos");

            migrationBuilder.DropColumn(
                name: "soXe",
                table: "PhiDuongBos");

            migrationBuilder.DropColumn(
                name: "thoiGianSuDung",
                table: "PhiDuongBos");
        }
    }
}
