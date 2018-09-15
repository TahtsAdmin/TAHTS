using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TAHTSData.Migrations
{
    public partial class UpdatedEventstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EventStatud",
                table: "Events",
                newName: "EventStatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EventStatus",
                table: "Events",
                newName: "EventStatud");
        }
    }
}
