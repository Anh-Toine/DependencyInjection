using System;
using System.Collections.Generic;

namespace DependencyInjection.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
