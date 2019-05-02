using Microsoft.EntityFrameworkCore.Migrations;

namespace GSoft.AbpZeroTemplate.Migrations
{
    public partial class updatebytinh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "donViSuDung",
                table: "ThongTinXes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tenChuPhuongTien",
                table: "ThongTinXes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "donViSuDung",
                table: "ThongTinXes");

            migrationBuilder.DropColumn(
                name: "tenChuPhuongTien",
                table: "ThongTinXes");
        }
    }
}
