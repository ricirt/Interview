using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class BranchTableCCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Locations_LocationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Branch",
                table: "Locations");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Users",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_LocationId",
                table: "Users",
                newName: "IX_Users_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Locations",
                newName: "DepartmentName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Locations",
                newName: "DepartmentId");

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                    table.ForeignKey(
                        name: "FK_Branches_Locations_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Locations",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branches_DepartmentId",
                table: "Branches",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Locations_DepartmentId",
                table: "Users",
                column: "DepartmentId",
                principalTable: "Locations",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Locations_DepartmentId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Users",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_DepartmentId",
                table: "Users",
                newName: "IX_Users_LocationId");

            migrationBuilder.RenameColumn(
                name: "DepartmentName",
                table: "Locations",
                newName: "Department");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Locations",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Branch",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Locations_LocationId",
                table: "Users",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
