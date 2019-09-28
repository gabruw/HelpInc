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
            modelBuilder.Ignore<Empresa>();
            modelBuilder.Ignore<Endereco>();
            modelBuilder.Ignore<Login>();
            modelBuilder.Ignore<Prestador>();

            modelBuilder.ApplyConfiguration(new EmpresaConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new LoginConfiguration());
            modelBuilder.ApplyConfiguration(new PrestadorConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Empresa> Empresa { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Login> Login { get; set; }
        public DbSet<Prestador> Prestador { get; set; }
    }