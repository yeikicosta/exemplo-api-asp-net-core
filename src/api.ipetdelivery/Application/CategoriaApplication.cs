using api.ipetdelivery.Models;
using api.ipetdelivery.Repository;

namespace api.ipetdelivery.Application
{
    public class CategoriaApplication : BaseApplication<Categoria>
    {
        public override BaseRepository<Categoria> GetRepository()
        {
            return new CategoriaRepository();
        }
        public CategoriaApplication() : base() { }
    }
}
