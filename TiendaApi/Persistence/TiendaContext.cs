using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Persistence
{
    public class TiendaContext: IdentityDbContext<User>
    {
        public TiendaContext(DbContextOptions<TiendaContext> options)
            :base(options)
        {

        }
        public DbSet<Producto> Productos { get; set; }
    }
}
