using Microsoft.EntityFrameworkCore.Migrations;

namespace web1_1.DAL.Migrations
{
    public partial class EntitiesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WheelchairGroups",
                columns: table => new
                {
                    WheelchairGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WheelchairGroups", x => x.WheelchairGroupId);
                });

            migrationBuilder.CreateTable(
                name: "Wheelchairs",
                columns: table => new
                {
                    WheelchairId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WheelchairName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    WheelchairGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wheelchairs", x => x.WheelchairId);
                    table.ForeignKey(
                        name: "FK_Wheelchairs_WheelchairGroups_WheelchairGroupId",
                        column: x => x.WheelchairGroupId,
                        principalTable: "WheelchairGroups",
                        principalColumn: "WheelchairGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wheelchairs_WheelchairGroupId",
                table: "Wheelchairs",
                column: "WheelchairGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wheelchairs");

            migrationBuilder.DropTable(
                name: "WheelchairGroups");
        }
    }
}
