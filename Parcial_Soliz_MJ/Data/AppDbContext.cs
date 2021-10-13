using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parcial_Soliz_MJ.Naipes;

namespace Parcial_Soliz_MJ.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Parcial_Soliz_MJ.Naipes.Naipe> Naipe { get; set; }
        public object Naipes { get; internal set; }
    }
}
