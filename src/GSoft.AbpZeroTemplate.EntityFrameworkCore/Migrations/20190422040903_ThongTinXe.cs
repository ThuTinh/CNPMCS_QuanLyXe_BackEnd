using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GSoft.AbpZeroTemplate.Migrations
{
    public partial class ThongTinXe : Migration
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
                    hangSanXuat = table.Column<string>(nullable: true),
                    loaiHopSo = table.Column<string>(nullable: true),
                    theTichDongCo = table.Column<float>(nullable: false),
                    model = table.Column<string>(nullable: true),
                    nuocSanXuat = table.Column<string>(nullable: true),
                    loaiNhienLieu = table.Column<string>(nullable: true),
                    soMay = table.Column<string>(nullable: true),
                    loaiXe = table.Column<string>(nullable: true),
                    namSanXuat = table.Column<int>(nullable: false),
                    dinhMucNhienLieu = table.Column<float>(nullable: false),
                    soSuon = table.Column<string>(nullable: true)
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
