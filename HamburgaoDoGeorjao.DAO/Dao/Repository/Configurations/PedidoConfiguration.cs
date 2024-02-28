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
    public class PedidoConfiguration : IEntityTypeConfiguration<PedidoVo>
    {
        public void Configure(EntityTypeBuilder<PedidoVo> builder)
        {
            builder.ToTable("Pedido");
            builder.HasKey(x => x.Id);

            builder.HasOne(pedido => pedido.Cliente)
                   .WithMany(cliente => cliente.Pedido)
                   .HasForeignKey(pedido => pedido.ClienteId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(pedido => pedido.CarrinhoDeCompras)
                   .WithOne(carrinho => carrinho.Pedido)
                   .HasForeignKey<CarrinhoDeComprasVo>(carrinho => carrinho.PedidoId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
