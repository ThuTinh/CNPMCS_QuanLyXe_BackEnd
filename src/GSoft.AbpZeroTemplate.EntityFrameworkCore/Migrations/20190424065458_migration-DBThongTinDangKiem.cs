using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GSoft.AbpZeroTemplate.Migrations
{
    public partial class migrationDBThongTinDangKiem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThongTinDangKiems",
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
                    ngayDangKiem = table.Column<DateTime>(nullable: false),
                    ngayHetHanDangKiem = table.Column<DateTime>(nullable: false),
                    thoiHanDangKiem = table.Column<DateTime>(nullable: false),
                    coQuanDangKiem = table.Column<string>(nullable: true),
                    trangThaiDuyet = table.Column<string>(nullable: true),
                    ghiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinDangKiems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThongTinDangKiems");
        }
    }
}
