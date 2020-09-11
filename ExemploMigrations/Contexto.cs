using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploMigrations
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public Contexto() : base("ExemploMigrations.Properties.Settings.exemplo_migrationsConnectionString")
        {
        }
    }
}
