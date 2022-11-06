using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace patientManagementServer.Data
{
    internal sealed class AppDBContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        => dbContextOptionsBuilder.UseSqlite("Data Source=./Data/AppDB.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Patient[] patientsToSeed = new Patient[6];

            for (int i = 1; i <= 6; i++)
            {
                patientsToSeed[i - 1] = new Patient
                {
                    Id = i,
                    firstname = "firstname" + i.ToString(),
                    lastname = "lastname" + i.ToString(),
                    dob = 20000000+i*20000+i*100+i*3,
                    patientsex = (i % 2 == 0) ? "Male" : "Female",
                    email = "mail" + i.ToString() + "@mail.mail",
                    town = "town" + i.ToString()
                };
            }

            modelBuilder.Entity<Patient>().HasData(patientsToSeed);
        }
    }


}