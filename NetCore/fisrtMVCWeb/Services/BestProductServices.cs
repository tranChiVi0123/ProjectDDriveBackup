using fisrtMVCWeb.Models;
using System.Collections.Generic;
namespace fisrtMVCWeb.Services
{
    public class BestProductService : IProductService
    {
        public List<ProductViewModel> getAll()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel {Id = 1, Name = "Television" },
                new ProductViewModel {Id = 2, Name = "Refrigerator" },
                new ProductViewModel {Id = 3, Name = "IPhone" },
                new ProductViewModel {Id = 4, Name = "Laptop" },
            };
        }
    }
}