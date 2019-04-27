using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GSoft.AbpZeroTemplate.Migrations
{
    public partial class initthongtinxe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    soXe = table.Column<string>(nullable: true),
                    model = table.Column<string>(nullable: true),
                    nuocSanXuat = table.Column<string>(nullable: true),
                    loaiNhienLieu = table.Column<string>(nullable: true),
                    namSanXuat = table.Column<int>(nullable: true),
                    mauXe = table.Column<string>(nullable: true),
                    maTaiSan = table.Column<string>(nullable: true),
                    mucDichSuDung = table.Column<string>(nullable: true),
                    ngayDangKiBanDau = table.Column<DateTime>(nullable: true),
                    soMay = table.Column<string>(nullable: true),
                    soSuon = table.Column<string>(nullable: true),
                    coLopSuDung = table.Column<string>(nullable: true),
                    kieuDongCo = table.Column<string>(nullable: true),
                    loaiHopSo = table.Column<string>(nullable: true),
                    theTichDongCo = table.Column<string>(nullable: true),
                    chieuDai = table.Column<string>(nullable: true),
                    chieuCao = table.Column<string>(nullable: true),
                    chieuNgang = table.Column<string>(nullable: true),
                    trangThaiDuyet = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinXes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThongTinXes");
        }
    }
}
