using System.Collections.Generic;

namespace api.ipetdelivery.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T>
    {
        public abstract IEnumerable<T> get();
    }
}
