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
    public class CarrinhoDeComprasConfiguration : IEntityTypeConfiguration<CarrinhoDeComprasVo>
    {
        public void Configure(EntityTypeBuilder<CarrinhoDeComprasVo> builder)
        {
            builder.ToTable("CarrinhoDeCompras");
            builder.HasKey(x => x.Id);

            builder.HasOne(carrinho => carrinho.Cliente)
                   .WithOne(cliente => cliente.CarrinhoDeCompras)
                   .HasForeignKey<CarrinhoDeComprasVo>(carrinho => carrinho.ClienteId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(carrinho => carrinho.Pedido)
                   .WithOne(pedido => pedido.CarrinhoDeCompras)
                   .HasForeignKey<PedidoVo>(pedido => pedido.CarrinhoDeComprasId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
