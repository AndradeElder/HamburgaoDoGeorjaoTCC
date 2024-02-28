using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HamburgaoDoGeorjao.Mvc.Models;
using RegraDeNegocios.Entidades;

namespace HamburgaoDoGeorjao.Mvc.Data
{
    public class HamburgaoDoGeorjaoMvcContext : DbContext
    {

        public HamburgaoDoGeorjaoMvcContext (DbContextOptions<HamburgaoDoGeorjaoMvcContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HamburgaoDoGeorjaoMvcContext).Assembly);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
