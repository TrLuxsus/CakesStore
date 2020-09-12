using System.Linq;

namespace CakesStore.Models
{
    public interface IStoreRepository
    {

        IQueryable<Product> Products { get; }
    }
}
