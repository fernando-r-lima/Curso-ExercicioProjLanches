using LanchesProj.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesProj.Context
{
    public class LanchesProjDBContext : DbContext
    {
        public LanchesProjDBContext(DbContextOptions<LanchesProjDBContext> options) : base(options)
        {}

        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
