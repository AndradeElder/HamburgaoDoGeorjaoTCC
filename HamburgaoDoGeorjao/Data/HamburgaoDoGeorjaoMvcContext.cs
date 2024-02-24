using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HamburgaoDoGeorjao.Mvc.Models;

namespace HamburgaoDoGeorjao.Mvc.Data
{
    public class HamburgaoDoGeorjaoMvcContext : DbContext
    {
        public HamburgaoDoGeorjaoMvcContext (DbContextOptions<HamburgaoDoGeorjaoMvcContext> options)
            : base(options)
        {
        }

        public DbSet<HamburgaoDoGeorjao.Mvc.Models.Movie> Movie { get; set; } = default!;
    }
}
