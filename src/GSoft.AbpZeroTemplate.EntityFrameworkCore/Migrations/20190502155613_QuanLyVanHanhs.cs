using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GSoft.AbpZeroTemplate.Migrations
{
    public partial class QuanLyVanHanhs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuanLyVanHanhs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    SoXe = table.Column<string>(nullable: true),
                    NgayCapNhat = table.Column<DateTime>(nullable: true),
                    SoKM = table.Column<int>(nullable: true),
                    XangTieuThu = table.Column<int>(nullable: true),
                    TrangThaiDaDuyet = table.Column<int>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanLyVanHanhs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinBaoDuongs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    SoXe = table.Column<string>(nullable: true),
                    NgayBaoDuong = table.Column<DateTime>(nullable: true),
                    NgayBaoDuongTiepTheo = table.Column<DateTime>(nullable: true),
                    SoTienThanhToan = table.Column<int>(nullable: true),
                    HangMucBaoDuong = table.Column<string>(nullable: true),
                    DonViBaoDuong = table.Column<string>(nullable: true),
                    TrangThaiDuyet = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinBaoDuongs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuanLyVanHanhs");

            migrationBuilder.DropTable(
                name: "ThongTinBaoDuongs");
        }
    }
}
