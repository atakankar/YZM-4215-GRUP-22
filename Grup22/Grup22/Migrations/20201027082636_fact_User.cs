using Microsoft.EntityFrameworkCore.Migrations;

namespace Grup22.Migrations
{
    public partial class fact_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fabrika Kullanıcısı",
                columns: table => new
                {
                    fact_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fact_Email = table.Column<string>(maxLength: 30, nullable: false),
                    fact_Password = table.Column<string>(nullable: false),
                    fact_Name = table.Column<string>(maxLength: 50, nullable: false),
                    fact_Adress = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabrika Kullanıcısı", x => x.fact_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fabrika Kullanıcısı");
        }
    }
}
