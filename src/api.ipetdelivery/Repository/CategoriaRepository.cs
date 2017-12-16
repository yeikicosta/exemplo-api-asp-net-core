using api.ipetdelivery.Models;
using System.Collections.Generic;

namespace api.ipetdelivery.Repository
{
    public class CategoriaRepository : BaseRepository<Categoria>
    {
        public override IEnumerable<Categoria> get()
        {
            return new List<Categoria>() {
                new Categoria()
                {
                    idCategoria = 1,
                    descricao = "Pet"
                },
                new Categoria()
                {
                    idCategoria = 2,
                    descricao = "Banho e tosa"
                },
                new Categoria()
                {
                    idCategoria = 3,
                    descricao = "Adestramento"
                }
            };
        }
    }
}
