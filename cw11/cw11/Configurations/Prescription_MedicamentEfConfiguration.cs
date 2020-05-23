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
        }
    }
}
