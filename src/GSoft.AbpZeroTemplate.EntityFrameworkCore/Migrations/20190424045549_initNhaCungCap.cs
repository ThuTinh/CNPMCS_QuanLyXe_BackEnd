using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GSoft.AbpZeroTemplate.Migrations
{
    public partial class initNhaCungCap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhaCungCaps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    maCongTyBaoHiem = table.Column<string>(nullable: true),
                    tenCongTyBaoHiem = table.Column<string>(nullable: true),
                    diaChi = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    maSoThue = table.Column<string>(nullable: true),
                    soDienThoai = table.Column<string>(nullable: true),
                    nguoiLienHe = table.Column<string>(nullable: true),
                    hoatDong = table.Column<bool>(nullable: false),
                    ghiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCaps", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhaCungCaps");
        }
    }
}
