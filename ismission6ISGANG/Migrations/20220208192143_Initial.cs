using Microsoft.EntityFrameworkCore.Migrations;

namespace ismission6ISGANG.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    TaskID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Task = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Quadrant = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Completed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.TaskID);
                    table.ForeignKey(
                        name: "FK_responses_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Home" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "School" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Work" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 4, "Church" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "TaskID", "CategoryId", "Completed", "Date", "Quadrant", "Task" },
                values: new object[] { 1, 1, false, "03/12/22", 1, "Crises" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "TaskID", "CategoryId", "Completed", "Date", "Quadrant", "Task" },
                values: new object[] { 2, 2, false, "04/15/22", 2, "Relationship Building" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "TaskID", "CategoryId", "Completed", "Date", "Quadrant", "Task" },
                values: new object[] { 3, 3, false, "2/28/22", 3, "Interruptions" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "TaskID", "CategoryId", "Completed", "Date", "Quadrant", "Task" },
                values: new object[] { 4, 3, true, "04/01/22", 4, "Some Phone Work" });

            migrationBuilder.CreateIndex(
                name: "IX_responses_CategoryId",
                table: "responses",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
