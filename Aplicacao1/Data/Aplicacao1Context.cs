using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aplicacao1.Models;

namespace Aplicacao1.Data
{
    public class Aplicacao1Context : DbContext
    {
        public Aplicacao1Context (DbContextOptions<Aplicacao1Context> options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
