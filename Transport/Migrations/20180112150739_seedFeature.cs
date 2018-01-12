using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Transport.Migrations
{
    public partial class seedFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Features(Name) Values ('Feaure1')");
            migrationBuilder.Sql("INSERT INTO Features (Name) Values('Feature2')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
