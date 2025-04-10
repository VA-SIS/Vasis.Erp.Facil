using Microsoft.EntityFrameworkCore;
using Vasis.Erp.Facil.Shared.Entities;

namespace Vasis.Erp.Facil.Server.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options) { }

    // Adicione seus DbSets aqui, exemplo:
    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<Pessoa> Pessoas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.Entity<Empresa>()

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.Property(e => e.RazaoSocial)
                .IsRequired()
                .HasMaxLength(150);

            entity.Property(e => e.Cnpj)
                .HasMaxLength(18);

            entity.HasIndex(e => e.Cnpj).IsUnique();
        });


    }

}
