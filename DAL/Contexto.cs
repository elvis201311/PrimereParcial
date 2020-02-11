using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerParcial.DAL
{
    class Contexto : DbContext

    {
        public DbSet<Entidades> Entidades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = ELVIS\MSSQLSERVER1; Database = VentasDb; Trusted_Connection = True;");
        }
    }
}
