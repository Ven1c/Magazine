using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazine.Domain;
using Magazine.Domain.Services;
using Magazine.Domain.Commands;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Magazine.Persistance
{
    
    public class ProductService:IProductService
    {
        private readonly IMagazineDbContext _MagazineDbContext;
       public Product Add(AddCommand addCommand)
        {
            var prod = new Product
            {
                id = Guid.NewGuid(),
                Name = addCommand.Name,
                Description = addCommand.Description,
                Price = addCommand.Price,
                ImageSrc = addCommand.ImageSrc
            };
           _MagazineDbContext.Product_.Add(prod);
            _MagazineDbContext.SaveChanges();
            return prod;
        }
       public Product Remove(Product remuvble)
        {
            return prod;
        }
       public Product Edit(Product editble)
        {
            return prod;
        }
       public Product Search(Product searchble)
        {
            return prod;
        }
    }
}
