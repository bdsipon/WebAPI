using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Transport.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes(Name) Values('Make1')");
            migrationBuilder.Sql("INSERT INTO Makes(Name) Values('Make2')");

            migrationBuilder.Sql("INSERT INTO Models (Name,MakeId) VALUES('Make1-ModelA',(SELECT ID FROM Makes WHERE Name='Make1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name,MakeId) VALUES('Make1-ModelB',(SELECT ID FROM Makes WHERE Name='Make1'))");

            migrationBuilder.Sql("INSERT INTO Models (Name,MakeId) VALUES('Make2-ModelA',(SELECT ID FROM Makes WHERE Name='Make2'))");
            migrationBuilder.Sql("INSERT INTO Models (Name,MakeId) VALUES('Make2-ModelB',(SELECT ID FROM Makes WHERE Name='Make2'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
