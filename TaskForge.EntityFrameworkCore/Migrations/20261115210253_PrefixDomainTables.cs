using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskForge.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class PrefixDomainTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectMembers",
                table: "ProjectMembers");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "TFTasks");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "TFTags");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "TFProjects");

            migrationBuilder.RenameTable(
                name: "ProjectMembers",
                newName: "TFProjectMembers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TFTasks",
                table: "TFTasks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TFTags",
                table: "TFTags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TFProjects",
                table: "TFProjects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TFProjectMembers",
                table: "TFProjectMembers",
                columns: new[] { "ProjectId", "UserId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TFTasks",
                table: "TFTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TFTags",
                table: "TFTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TFProjects",
                table: "TFProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TFProjectMembers",
                table: "TFProjectMembers");

            migrationBuilder.RenameTable(
                name: "TFTasks",
                newName: "Tasks");

            migrationBuilder.RenameTable(
                name: "TFTags",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "TFProjects",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "TFProjectMembers",
                newName: "ProjectMembers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectMembers",
                table: "ProjectMembers",
                columns: new[] { "ProjectId", "UserId" });
        }
    }
}
