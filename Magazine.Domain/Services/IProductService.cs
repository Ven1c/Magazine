using Magazine.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Domain.Services
{
    public interface IProductService
    {
       
        public Product Add(AddCommand addCommand);
        public Product Remove(Product remuvble);
        public Product Edit(Product product);
        public Product Search(string name);
        public List<Product> InitFromFile();
        public void WriteToFile(List<Product> products);
    }
}
