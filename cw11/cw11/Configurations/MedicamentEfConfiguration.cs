using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Configurations
{
    public class MedicamentEfConfiguration : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(e => e.IdMedicament);
            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.Description).HasMaxLength(100);
            builder.Property(e => e.Type).HasMaxLength(100);

            var list = new List<Medicament>();
            list.Add(new Medicament { IdMedicament = 1, Name = "Asdafsa", Description = "na bakterie", Type = "Antybiotyk" });
            list.Add(new Medicament { IdMedicament = 2, Name = "WitaminaC", Description = "wit C", Type = "Witamina" });
            list.Add(new Medicament { IdMedicament = 3, Name = "Tamtum", Description = "Na gardlo", Type = "Aerozol" });


            builder.HasData(list);
        }
    }
}
