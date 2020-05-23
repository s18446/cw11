using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Configurations
{
    public class PrescriptionEfConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(e => e.IdPrescription);
            builder.HasOne(e => e.Patient).WithMany().HasForeignKey(e => e.IdPatient);
            builder.HasOne(e => e.Doctor).WithMany().HasForeignKey(e => e.IdDoctor);


            var list = new List<Prescription>();
            list.Add(new Prescription { IdPrescription = 1, Date = Convert.ToDateTime("2018-05-05"), DueDate = Convert.ToDateTime("2019-01-07"), IdPatient = 1, IdDoctor = 1 });
            list.Add(new Prescription { IdPrescription = 2, Date = Convert.ToDateTime("2018-06-12"), DueDate = Convert.ToDateTime("2019-11-07"), IdPatient = 1, IdDoctor = 2 });
            list.Add(new Prescription { IdPrescription = 3, Date = Convert.ToDateTime("2018-06-21"), DueDate = Convert.ToDateTime("2012-07-17"), IdPatient = 2, IdDoctor = 3 });
            list.Add(new Prescription { IdPrescription = 4, Date = Convert.ToDateTime("2019-07-11"), DueDate = Convert.ToDateTime("2019-08-27"), IdPatient = 3, IdDoctor = 3 });
            list.Add(new Prescription { IdPrescription = 5, Date = Convert.ToDateTime("2019-08-06"), DueDate = Convert.ToDateTime("2020-04-12"), IdPatient = 3, IdDoctor = 4 });


            builder.HasData(list);
        }
    }
}

