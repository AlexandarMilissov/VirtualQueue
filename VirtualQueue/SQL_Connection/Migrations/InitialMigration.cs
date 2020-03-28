using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Connection.Migrations
{
    public class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    usersid = table.Column<int>(nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    mac = table.Column<int>(nullable: true),
                    queue = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.usersid);
                });
            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    managerid = table.Column<int>(nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    thirdname = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    phonenumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.managerid);
                });
            migrationBuilder.CreateTable(
                name: "Queues",
                columns: table => new
                {
                    queueid = table.Column<int>(nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    placename = table.Column<string>(nullable: true),
                    locationname = table.Column<string>(nullable: true),
                    managerid = table.Column<string>(nullable: true)
                });
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Users");
            migrationBuilder.DropTable(name: "Managers");
            migrationBuilder.DropTable(name: "Queues");
        }
    }
}
