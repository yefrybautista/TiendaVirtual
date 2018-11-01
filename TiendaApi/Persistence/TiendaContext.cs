using Microsoft.EntityFrameworkCore;
using Model;
using System;

namespace Persistence
{
    public class TiendaContext : DbContext
    {
        public TiendaContext(DbContextOptions<TiendaContext> options)
            :base(options)
        {

        }
        public DbSet<Producto> Productos { get; set; }
    }
}
