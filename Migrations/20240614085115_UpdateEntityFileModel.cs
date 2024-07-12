﻿using Microsoft.EntityFrameworkCore.Migrations;


namespace FileSharingService.Migrations;

/// <inheritdoc />
public partial class UpdateEntityFileModel : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<DateTime>(
            name: "Time",
            table: "Files",
            type: "timestamp with time zone",
            nullable: false,
            defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "Time",
            table: "Files");
    }
}
