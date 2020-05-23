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
        }
    }
}

