using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskForge.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TFTasks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreationTime",
                table: "TFTasks",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModificationTime",
                table: "TFTasks",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "TFTasks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TFTags",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreationTime",
                table: "TFTags",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModificationTime",
                table: "TFTags",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "TFTags",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TFProjects",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreationTime",
                table: "TFProjects",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModificationTime",
                table: "TFProjects",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "TFProjects",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TFProjectMembers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreationTime",
                table: "TFProjectMembers",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TFTasks");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "TFTasks");

            migrationBuilder.DropColumn(
                name: "ModificationTime",
                table: "TFTasks");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "TFTasks");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TFTags");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "TFTags");

            migrationBuilder.DropColumn(
                name: "ModificationTime",
                table: "TFTags");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "TFTags");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TFProjects");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "TFProjects");

            migrationBuilder.DropColumn(
                name: "ModificationTime",
                table: "TFProjects");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "TFProjects");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TFProjectMembers");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "TFProjectMembers");
        }
    }
}
