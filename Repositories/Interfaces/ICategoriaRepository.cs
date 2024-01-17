using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using suave.Models;

namespace suave.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}