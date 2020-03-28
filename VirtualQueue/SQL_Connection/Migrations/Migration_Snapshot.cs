using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Connection.Migrations
{
    [DbContext(typeof(DB_Connection))]
    public class Migration_SnapShot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity("Database.Entities.Users", b =>
            {
                b.Property<int>("usersId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("Mac")
                                .HasColumnType("int");

                b.Property<int>("queueId")
                                .HasColumnType("int");              
            });
            modelBuilder.Entity("Database.Entities.Queues", b =>
            {
                b.Property<int>("queueId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("placeName")
                                .HasColumnType("int");

                b.Property<int>("locationName")
                                .HasColumnType("int");
            });
            modelBuilder.Entity("Database.Entities.Managers", b =>
            {
                b.Property<int>("ManagerId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("firstName")
                                .HasColumnType("nvarchar(max)");
                b.Property<int>("thirdName")
                                .HasColumnType("nvarchar(max)");
                b.Property<int>("secondName")
                                .HasColumnType("nvarchar(max)");
                b.Property<int>("email")
                                .HasColumnType("nvarchar(max)");
                b.Property<int>("phoneNumber")
                                .HasColumnType("nvarchar(max)");
            });
        }
    }
}
