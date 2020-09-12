using System.Collections.Generic;
using CakesStore.Models;

namespace CakesStore.Models.ViewModels
{

    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
