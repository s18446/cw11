using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Configurations
{
    public class DoctorEfConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(e => e.IdDoctor);
            builder.Property(e => e.FirstName).HasMaxLength(100);
            builder.Property(e => e.LastName).HasMaxLength(100);
            builder.Property(e => e.Email).HasMaxLength(100);


            var list = new List<Doctor>();
            list.Add(new Doctor { IdDoctor = 1, FirstName = "Jan", LastName = "Kowalski", Email = "sad@sadfk.pl" });
            list.Add(new Doctor { IdDoctor = 2, FirstName = "Mariusz", LastName = "ToSarius", Email = "Padfgdgtyk@kss.pl" });
            list.Add(new Doctor { IdDoctor = 3, FirstName = "Ania", LastName = "Nowak", Email = "asdadad@kggk.pl" });
            list.Add(new Doctor { IdDoctor = 4, FirstName = "Tadeusz", LastName = "Soplica", Email = "dgfgdgdgdfg@asd.pl" });

            builder.HasData(list);
        }
    }
}
