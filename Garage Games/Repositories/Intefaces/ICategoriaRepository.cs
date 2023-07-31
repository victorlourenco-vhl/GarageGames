using Garage_Games.Models;

namespace Garage_Games.Repositories.Intefaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
