using Microsoft.EntityFrameworkCore.Migrations;

namespace SQL_Connection.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    secondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thirdName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                });

            migrationBuilder.CreateTable(
                name: "Queues",
                columns: table => new
                {
                    queueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numbeOfEnqueuedPeople = table.Column<int>(type: "int", nullable: false),
                    latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    longtitude = table.Column<string>(type: "float", nullable: false),
                    locationName = table.Column<string>(type: "float", nullable: false),
                    placeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    managerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queues", x => x.queueId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Mac = table.Column<int>(type: "int", nullable: false),
                    queueId = table.Column<int>(type: "int", nullable: false),
                    usersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                });  
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Queues");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
