using Domain.DTO;
using Microsoft.EntityFrameworkCore;
using Repository.Config;

namespace Repository.Context
{
    public class HelpIncContext : DbContext
    {
        public HelpIncContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Ignore<Consumidor>();
            //modelBuilder.Ignore<Empresa>();
            modelBuilder.Ignore<Endereco>();
            //modelBuilder.Ignore<Grupo>();
            modelBuilder.Ignore<Habilidade>();
            modelBuilder.Ignore<Login>();
            modelBuilder.Ignore<Prestador>();

            //modelBuilder.ApplyConfiguration(new ConsumidorConfiguration());
            //modelBuilder.ApplyConfiguration(new EmpresaConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            //modelBuilder.ApplyConfiguration(new GrupoConfiguration());
            modelBuilder.ApplyConfiguration(new HabilidadeConfiguration());
            modelBuilder.ApplyConfiguration(new LoginConfiguration());
            modelBuilder.ApplyConfiguration(new PrestadorConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        //public DbSet<Consumidor> Consumidor { get; set; }

        //public DbSet<Empresa> Empresa { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        //public DbSet<Grupo> Grupo { get; set; }

        public DbSet<Habilidade> Habilidade { get; set; }

        public DbSet<Login> Login { get; set; }
        
        public DbSet<Prestador> Prestador { get; set; }
    }
}
