using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class BranchTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Locations_DepartmentId",
                table: "Branches");

            migrationBuilder.DropIndex(
                name: "IX_Branches_DepartmentId",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Branches");

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_BranchId",
                table: "Locations",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Branches_BranchId",
                table: "Locations",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Branches_BranchId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_BranchId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Locations");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Branches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Branches_DepartmentId",
                table: "Branches",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_Locations_DepartmentId",
                table: "Branches",
                column: "DepartmentId",
                principalTable: "Locations",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
