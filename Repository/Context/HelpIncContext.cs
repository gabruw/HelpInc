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
            modelBuilder.Ignore<Endereco>();
            modelBuilder.Ignore<Login>();

            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new LoginConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Login> Login { get; set; }
    }
}