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
    public class HamburguerConfiguration : IEntityTypeConfiguration<HamburguerVo>
    {
        public void Configure(EntityTypeBuilder<HamburguerVo> builder)
        {
            builder.ToTable("Hamburguer");
            builder.HasKey(x => x.Id);

            builder.HasMany(hamburguer => hamburguer.Pedido)
                   .WithMany(pedido => pedido.Hamburguers)
        }
    }
}