using HamburgaoDoGeorjao.DAO.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgaoDoGeorjao.DAO.Dao.Repository.Configurations
{
    internal class IngredientesConfiguration : IEntityTypeConfiguration<IngredientesVo>
    {
        public void Configure(EntityTypeBuilder<IngredientesVo> builder)
        {
            builder.ToTable("Ingredientes");
            builder.HasKey(x => x.Id);

            builder.HasOne(ingrediente => ingrediente.Hamburguer)
                   .WithMany(hamburguer => hamburguer.Ingredientes)
                   .HasForeignKey(ingrediente => ingrediente.HamburguerId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}