// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SOFOIAN_EF_HT1;

#nullable disable

namespace SOFOIAN_EF_HT1.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20221026142707_DeleteDate")]
    partial class DeleteDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SOFOIAN_EF_HT1.MVVM.Model.OrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Summ")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.ToSqlQuery("USE Orders  UPDATE Orders SET Date = '2022-05-21'  WHERE Id=30 \n UPDATE Orders  SET Date = '2022-03-22'  WHERE Id=31\n UPDATE Orders  SET Date = '2022-04-19'  WHERE Id=32\n UPDATE Orders  SET Date = '2022-06-15'  WHERE Id=33\n UPDATE Orders  SET Date = '2022-09-12'  WHERE Id=34\n UPDATE Orders  SET Date = '2022-07-07'  WHERE Id=35\n UPDATE Orders  SET Date = '2022-02-11'  WHERE Id=36\n UPDATE Orders  SET Date = '2022-08-04'  WHERE Id=37\n UPDATE Orders  SET Date = '2022-01-14'  WHERE Id=38\n UPDATE Orders  SET Date = '2022-01-14'  WHERE Id=38\n UPDATE Orders  SET Date = '2022-12-21'  WHERE Id=39\n");

                    b.HasData(
                        new
                        {
                            Id = 30,
                            Summ = 52000.330000000002
                        },
                        new
                        {
                            Id = 31,
                            Summ = 53555.330000000002
                        },
                        new
                        {
                            Id = 32,
                            Summ = 2652000.3300000001
                        },
                        new
                        {
                            Id = 33,
                            Summ = 535872000.32999998
                        },
                        new
                        {
                            Id = 34,
                            Summ = 52025600.329999998
                        },
                        new
                        {
                            Id = 35,
                            Summ = 52000.330000000002
                        },
                        new
                        {
                            Id = 36,
                            Summ = 53555.330000000002
                        },
                        new
                        {
                            Id = 37,
                            Summ = 2652000.3300000001
                        },
                        new
                        {
                            Id = 38,
                            Summ = 535872000.32999998
                        },
                        new
                        {
                            Id = 39,
                            Summ = 52025600.329999998
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
