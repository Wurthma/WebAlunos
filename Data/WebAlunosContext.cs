using Microsoft.EntityFrameworkCore;
using WebAlunos.Models;

namespace WebAlunos.Data
{
    public class WebAlunosContext : DbContext
    {
        public WebAlunosContext(DbContextOptions<WebAlunosContext> options) : base(options)
        {
            
        }

        public DbSet<AlunoModel> Aluno { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlunoModel>().HasKey(k => k.Id); // Definindo minha PK

            modelBuilder.Entity<AlunoModel>()
            .Property(x => x.CPF)
            .HasMaxLength(11)
            .IsRequired();

            modelBuilder.Entity<AlunoModel>()
            .Property(x => x.Nome)
            .HasMaxLength(100)
            .IsRequired();
            
            base.OnModelCreating(modelBuilder);
        }
    }
}