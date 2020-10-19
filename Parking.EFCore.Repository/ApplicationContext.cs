using Microsoft.EntityFrameworkCore;
using Parking.EFCore.Dominio;

namespace Parking.EFCore.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationContext()
        {
        }

        //public DbSet<Estacionamento> Estacionamentos { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Estabelecimento> Estabelecimentos { get; set; }

        //public DbSet<Heroi> Herois { get; set; }
        //public DbSet<Batalha> Batalhas { get; set; }
        //public DbSet<Arma> Armas { get; set; }

        //public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }
        //public DbSet<IdentidadeSecreta> IdentidadesSecretas  { get; set; }

        public DbSet<RegistroVeiculo> RegistroVeiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Estacionamento>().HasKey(t => t.Id);
            //modelBuilder.Entity<Estacionamento>().HasMany(t => t.Veiculos);
            //modelBuilder.Entity<Estacionamento>().HasOne(t => t.Estabelecimento);

            modelBuilder.Entity<Veiculo>().HasKey(t => t.Id);

            modelBuilder.Entity<Estabelecimento>().HasKey(t => t.Id);

            //modelBuilder.Entity<HeroiBatalha>(entity => {
            //    entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
            //});

            //modelBuilder.Entity<RegistroVeiculo>().HasKey(t => t.Id);
            //modelBuilder.Entity<RegistroVeiculo>().HasMany(t => t.Veiculos);
            //modelBuilder.Entity<RegistroVeiculo>().HasOne(t => t.Estabelecimento);

            //modelBuilder.Entity<EstabelecimentoRegistroVeivulo>(entity => {
            //    entity.HasKey(e => new { e.EstabelecimentoId , e.RegistroVeiculoId, e.VeiculoId });
            //});
        }

    }
}