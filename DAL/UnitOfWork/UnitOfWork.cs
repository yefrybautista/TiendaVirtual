using DAL.Models;
using DAL.Repositories.Implementation;
using DAL.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private GeneralContext _context;

        public IGenericRepository<Producto> ProductoRepository { get; private set; }

        public UnitOfWork(GeneralContext context)
        {
            _context = context;
            ProductoRepository = new GenericRepository<Producto>(_context);
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
           return _context.SaveChangesAsync();
        }


    }
}
