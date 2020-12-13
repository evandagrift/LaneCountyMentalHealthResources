using Microsoft.EntityFrameworkCore.Migrations;

namespace LaneCountyMentalHealth.Migrations
{
    public partial class Initial_MSSQL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeedbackForum",
                columns: table => new
                {
                    FeedbackId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    Feedback = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackForum", x => x.FeedbackId);
                });

            migrationBuilder.CreateTable(
                name: "HomeForum",
                columns: table => new
                {
                    SelectionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeenYA = table.Column<string>(nullable: true),
                    FinancialMental = table.Column<string>(nullable: true),
                    GenderIdentity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeForum", x => x.SelectionId);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Catagory = table.Column<string>(nullable: true),
                    SubCatagory = table.Column<string>(nullable: true),
                    AdditionalNote = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedbackForum");

            migrationBuilder.DropTable(
                name: "HomeForum");

            migrationBuilder.DropTable(
                name: "Links");
        }
    }
}
