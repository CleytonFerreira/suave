using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using suave.Context;
using suave.Models;
using suave.Repositories.Interfaces;

namespace suave.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}