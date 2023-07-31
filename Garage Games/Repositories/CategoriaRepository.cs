using Garage_Games.Context;
using Garage_Games.Models;
using Garage_Games.Repositories.Intefaces;

namespace Garage_Games.Repositories
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
