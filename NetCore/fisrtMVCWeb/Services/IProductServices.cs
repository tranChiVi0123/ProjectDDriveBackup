using System.Collections.Generic;
using fisrtMVCWeb.Models;
namespace fisrtMVCWeb.Services
{
    public interface IProductService
    {
        List<ProductViewModel> getAll();
    }
}