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
    public class PedidoHamburguerConfiguration : IEntityTypeConfiguration<PedidoHamburguerVo>
    {
        public void Configure(EntityTypeBuilder<PedidoHamburguerVo> builder)
        {
            builder.ToTable("PedidoHamburguer");
            builder.HasKey(pedidoham => new { pedidoham.PedidoId, pedidoham.HamburguerId });

            builder.HasOne(pedidoham => pedidoham.Pedido)
                .WithMany(pedido => pedido.PedidoHamburguers)
                .HasForeignKey(pedidoham => pedidoham.PedidoId);

            builder.HasOne(pedidoham => pedidoham.Hamburguer)
                .WithMany(hamburguer => hamburguer.PedidoHamburguers)
                .HasForeignKey(pedidoham => pedidoham.HamburguerId);
        }
    }
}