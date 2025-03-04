
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Domain.Services
{
    public interface IMagazineDbContext
    {
        DbSet<Product> Product_ { get; set; }
        int SaveChanges();
    }
}
