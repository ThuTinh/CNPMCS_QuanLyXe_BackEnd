using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GSoft.AbpZeroTemplate.Migrations
{
    public partial class migrationDBThongTinBaoHiem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThongTinBaoHiems",
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
                    ngayMuaBaoHiem = table.Column<DateTime>(nullable: false),
                    ngayHetHanBaoHiem = table.Column<DateTime>(nullable: false),
                    thoiHanBaoHiem = table.Column<DateTime>(nullable: false),
                    congTyBaoHiem = table.Column<string>(nullable: true),
                    loaiBaoHiem = table.Column<string>(nullable: true),
                    soTienThanhToan = table.Column<int>(nullable: true),
                    trangThaiDuyet = table.Column<string>(nullable: true),
                    ghiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinBaoHiems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThongTinBaoHiems");
        }
    }
}
