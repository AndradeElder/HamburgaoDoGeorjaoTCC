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
    public class EnderecoConfiguration : IEntityTypeConfiguration<EnderecoVo>
    {
        public void Configure(EntityTypeBuilder<EnderecoVo> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(x => x.Id);

            builder.HasOne(endereco => endereco.Cliente)
                   .WithMany(cliente => cliente.Enderecos)
                   .HasForeignKey(pedido => pedido.ClienteId)
                   .HasConstraintName("ForeignKey_Endereco_Cliente");
        }
    }
}