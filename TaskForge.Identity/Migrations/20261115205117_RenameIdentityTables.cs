using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskForge.Identity.Migrations
{
    /// <inheritdoc />
    public partial class RenameIdentityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "TFUserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "TFUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "TFUserRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "TFUserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "TFUserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "TFRoles");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "TFRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "TFUserRoles",
                newName: "IX_TFUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "TFUserLogins",
                newName: "IX_TFUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "TFUserClaims",
                newName: "IX_TFUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "TFRoleClaims",
                newName: "IX_TFRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TFUserTokens",
                table: "TFUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TFUsers",
                table: "TFUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TFUserRoles",
                table: "TFUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TFUserLogins",
                table: "TFUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TFUserClaims",
                table: "TFUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TFRoles",
                table: "TFRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TFRoleClaims",
                table: "TFRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TFRoleClaims_TFRoles_RoleId",
                table: "TFRoleClaims",
                column: "RoleId",
                principalTable: "TFRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TFUserClaims_TFUsers_UserId",
                table: "TFUserClaims",
                column: "UserId",
                principalTable: "TFUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TFUserLogins_TFUsers_UserId",
                table: "TFUserLogins",
                column: "UserId",
                principalTable: "TFUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TFUserRoles_TFRoles_RoleId",
                table: "TFUserRoles",
                column: "RoleId",
                principalTable: "TFRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TFUserRoles_TFUsers_UserId",
                table: "TFUserRoles",
                column: "UserId",
                principalTable: "TFUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TFUserTokens_TFUsers_UserId",
                table: "TFUserTokens",
                column: "UserId",
                principalTable: "TFUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TFRoleClaims_TFRoles_RoleId",
                table: "TFRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_TFUserClaims_TFUsers_UserId",
                table: "TFUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_TFUserLogins_TFUsers_UserId",
                table: "TFUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_TFUserRoles_TFRoles_RoleId",
                table: "TFUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_TFUserRoles_TFUsers_UserId",
                table: "TFUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_TFUserTokens_TFUsers_UserId",
                table: "TFUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TFUserTokens",
                table: "TFUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TFUsers",
                table: "TFUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TFUserRoles",
                table: "TFUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TFUserLogins",
                table: "TFUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TFUserClaims",
                table: "TFUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TFRoles",
                table: "TFRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TFRoleClaims",
                table: "TFRoleClaims");

            migrationBuilder.RenameTable(
                name: "TFUserTokens",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "TFUsers",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "TFUserRoles",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "TFUserLogins",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "TFUserClaims",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "TFRoles",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "TFRoleClaims",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_TFUserRoles_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_TFUserLogins_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TFUserClaims_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TFRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
