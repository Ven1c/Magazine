using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Domain.Services
{
    internal interface IProductService
    {
        Product Add();
        Product Remove(Product product);
        Product Edit(Product product);
        Product Search();
    }
}
