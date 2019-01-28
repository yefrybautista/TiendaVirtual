using DAL.Models;
using DAL.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Producto> ProductoRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
