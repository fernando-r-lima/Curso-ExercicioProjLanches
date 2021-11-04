using LanchesProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanchesProj.Context;

namespace LanchesProj.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly LanchesProjDBContext _context;
        public CategoriaRepository(LanchesProjDBContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
