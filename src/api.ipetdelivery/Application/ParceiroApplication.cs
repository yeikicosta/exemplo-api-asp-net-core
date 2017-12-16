using api.ipetdelivery.Models;
using api.ipetdelivery.Repository;
using System.Collections.Generic;
using System.Linq;

namespace api.ipetdelivery.Application
{
    public class ParceiroApplication : BaseApplication<Parceiro>
    {
        public override BaseRepository<Parceiro> GetRepository()
        {
            return new ParceiroRepository();
        }
        public ParceiroApplication() : base() { }

        public IEnumerable<Parceiro> getParceirosPorCategoria(int idCategoria)
        {
            List<Parceiro> Parceiros = get().ToList();
            return Parceiros.FindAll(p => p.categoria.idCategoria == idCategoria);
        }
    }
}
