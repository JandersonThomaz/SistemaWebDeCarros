using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaWebDeCarros.Models
{
    public class SistemaWebDeCarrosContext : DbContext
    {
        public SistemaWebDeCarrosContext (DbContextOptions<SistemaWebDeCarrosContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaWebDeCarros.Models.Carro> Carros { get; set; }
    }
}
