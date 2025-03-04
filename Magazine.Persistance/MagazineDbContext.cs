using Magazine.Domain;
using Magazine.Domain.Commands;
using Magazine.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Persistance
{
    public class MagazineDbContext : DbContext, IMagazineDbContext
    {
        public DbSet<Product> Product_ { get; set; }
        public MagazineDbContext(DbContextOptions<MagazineDbContext> options)
     : base(options) { }
        protected override void OnModelCreating(ModelBuilder Builder)
        {
         
            
            base.OnModelCreating(Builder);

        }
    }
    
}
