using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GSoft.AbpZeroTemplate.Migrations
{
    public partial class initThongTinXe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThongTinVanHanhXes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    SoKm = table.Column<float>(nullable: false),
                    XangTieuThu = table.Column<float>(nullable: false),
                    TrangThai = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    ThongTinXeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinVanHanhXes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinXes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ThongTinXeId = table.Column<string>(nullable: true),
                    HangSanXuat = table.Column<string>(nullable: true),
                    TheTichDongCo = table.Column<string>(nullable: true),
                    NuocSanXuat = table.Column<string>(nullable: true),
                    LoaiNhienLieu = table.Column<string>(nullable: true),
                    LoaiXe = table.Column<string>(nullable: true),
                    NamSanXuat = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinXes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThongTinVanHanhXes");

            migrationBuilder.DropTable(
                name: "ThongTinXes");
        }
    }
}
