using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GSoft.AbpZeroTemplate.Migrations
{
    public partial class initTaiSan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaiSans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    maTaiSan = table.Column<string>(nullable: true),
                    tenTaiSan = table.Column<string>(nullable: true),
                    nhomTaiSan = table.Column<string>(nullable: true),
                    loaiTaiSan = table.Column<string>(nullable: true),
                    thongTinMoTa = table.Column<string>(nullable: true),
                    nguyenGiaTaiSan = table.Column<long>(nullable: true),
                    donViSuDung = table.Column<string>(nullable: true),
                    tinhTrangTaiSan = table.Column<string>(nullable: true),
                    nguoiSuDung = table.Column<string>(nullable: true),
                    tinhTrangKhauHao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiSans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaiSans");
        }
    }
}
