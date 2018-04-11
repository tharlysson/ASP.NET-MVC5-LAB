using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TB.CursoMVC.Domain.Models;
using TB.CursoMVC.Infra.Data.EntityConfig;

namespace TB.CursoMVC.Infra.Data.Context
{
    public class CursoMvcContext : DbContext
    {
        public CursoMvcContext()
            //:base("DefaultConnection")
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            // chama as configurações
            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}