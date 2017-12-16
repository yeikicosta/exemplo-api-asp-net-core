using System.Collections.Generic;

namespace api.ipetdelivery.Repository
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> get();
    }
}
