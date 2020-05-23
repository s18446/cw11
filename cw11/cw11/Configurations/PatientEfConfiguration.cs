using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Configurations
{
    public class PatientEfConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(e => e.IdPatient);
            builder.Property(e => e.FirstName).HasMaxLength(100);
            builder.Property(e => e.LastName).HasMaxLength(100);


            var list = new List<Patient>();
            list.Add(new Patient { IdPatient = 1, FirstName = "Daniel", LastName = "Rogowski", BirthDate = Convert.ToDateTime("1998-03-01") });
            list.Add(new Patient { IdPatient = 2, FirstName = "Piotr", LastName = "Kowalski", BirthDate = Convert.ToDateTime("2002-04-11") });
            list.Add(new Patient { IdPatient = 3, FirstName = "Hanna", LastName = "Nowak", BirthDate = Convert.ToDateTime("1987-05-12") });


            builder.HasData(list);
        }
    }
}
