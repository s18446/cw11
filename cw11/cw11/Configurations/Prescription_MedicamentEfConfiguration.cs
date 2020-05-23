using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Configurations
{
    public class Prescription_MedicamentEfConfiguration : IEntityTypeConfiguration<Prescription_Medicament>
    {
        public void Configure(EntityTypeBuilder<Prescription_Medicament> builder)
        {
            builder.HasKey(e => new { e.IdMedicament, e.IdPrescription });
            builder.HasOne(e => e.Prescription).WithMany().HasForeignKey(e => e.IdPrescription);
            builder.HasOne(e => e.Medicament).WithMany().HasForeignKey(e => e.IdMedicament);
            builder.Property("Details").
                HasMaxLength(100);

            var list = new List<Prescription_Medicament>();
            list.Add(new Prescription_Medicament { IdMedicament = 3, IdPrescription = 1, Dose = 4, Details = "asdadadad" });
            list.Add(new Prescription_Medicament { IdMedicament = 2, IdPrescription = 2, Dose = 8, Details = "dfgdgdgdfgdg" });
            list.Add(new Prescription_Medicament { IdMedicament = 1, IdPrescription = 1, Dose = 20, Details = "sadadasfafsaf" });
            list.Add(new Prescription_Medicament { IdMedicament = 2, IdPrescription = 3, Dose = 15, Details = "asdadafdsafsf" });
            list.Add(new Prescription_Medicament { IdMedicament = 3, IdPrescription = 3, Dose = 10, Details = "asdasfsgfsgsg" });


            builder.HasData(list);
        }
    }
}
