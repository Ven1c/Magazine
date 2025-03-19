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
using System.Threading;

namespace Magazine.Persistance
{
    
    public class ProductService:IProductService
    {
        private readonly IMagazineDbContext _MagazineDbContext;
        public ProductService(IMagazineDbContext context)=>
            _MagazineDbContext = context;
        
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
            var entity =  _MagazineDbContext.Product_
                .Find(new object[] { remuvble.id });
            _MagazineDbContext.Product_.Remove(entity);
            _MagazineDbContext.SaveChanges();
            return entity;
        }
       public Product Edit(Product editble)
        {
            var entity = _MagazineDbContext.Product_
                .Find(new object[] { editble.id });
            entity.Name = editble.Name;
            entity.Description = editble.Description;
            entity.Price = editble.Price;
            entity.ImageSrc = editble.ImageSrc;
            _MagazineDbContext.SaveChanges();

            return entity;
        }
       public Product Search(string name)
        {
            var entity = _MagazineDbContext.Product_
               .SingleOrDefault( prod =>prod.Name == name);
            return entity;
        }
    }
}
