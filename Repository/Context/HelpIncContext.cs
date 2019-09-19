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

            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Endereco> Endereco { get; set; }
    }
}