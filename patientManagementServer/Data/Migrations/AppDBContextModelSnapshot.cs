// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using patientManagementServer.Data;

#nullable disable

namespace patientManagementServer.Data.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("patientManagementServer.Data.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("dob")
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("firstname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("patientsex")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("town")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            dob = 20000102,
                            email = "mail1@mail.mail",
                            firstname = "firstname1",
                            lastname = "lastname1",
                            patientsex = "Female",
                            town = "town1"
                        },
                        new
                        {
                            Id = 2,
                            dob = 20000204,
                            email = "mail2@mail.mail",
                            firstname = "firstname2",
                            lastname = "lastname2",
                            patientsex = "Male",
                            town = "town2"
                        },
                        new
                        {
                            Id = 3,
                            dob = 20000306,
                            email = "mail3@mail.mail",
                            firstname = "firstname3",
                            lastname = "lastname3",
                            patientsex = "Female",
                            town = "town3"
                        },
                        new
                        {
                            Id = 4,
                            dob = 20000408,
                            email = "mail4@mail.mail",
                            firstname = "firstname4",
                            lastname = "lastname4",
                            patientsex = "Male",
                            town = "town4"
                        },
                        new
                        {
                            Id = 5,
                            dob = 20000510,
                            email = "mail5@mail.mail",
                            firstname = "firstname5",
                            lastname = "lastname5",
                            patientsex = "Female",
                            town = "town5"
                        },
                        new
                        {
                            Id = 6,
                            dob = 20000612,
                            email = "mail6@mail.mail",
                            firstname = "firstname6",
                            lastname = "lastname6",
                            patientsex = "Male",
                            town = "town6"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
