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
    public class ClienteConfiguration : IEntityTypeConfiguration<ClienteVo>
    {
        public void Configure(EntityTypeBuilder<ClienteVo> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(x => x.Id);

            builder.HasMany(cliente => cliente.Pedido)
                   .WithOne(pedido => pedido.Cliente)
                   .HasForeignKey(pedido => pedido.ClienteId)
                   .HasConstraintName("ForeignKey_Cliente_Pedido");

            builder.HasMany(cliente => cliente.Enderecos)
                   .WithOne(endereco => endereco.Cliente)
                   .HasForeignKey(endereco => endereco.ClienteId)
                   .HasConstraintName("ForeignKey_Cliente_Endereco");
        }
    }
}