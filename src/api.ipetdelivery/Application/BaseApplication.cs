using api.ipetdelivery.Repository;
using System.Collections.Generic;

namespace api.ipetdelivery.Application
{
    public abstract class BaseApplication<T>  where T : class
    {
        private IBaseRepository<T> _BaseRepository = null;

        public BaseApplication()
        {
            _BaseRepository = GetRepository();
        }

        public IEnumerable<T> get()
        {
            return _BaseRepository.get();
        }

        public abstract BaseRepository<T> GetRepository();
    }
}
