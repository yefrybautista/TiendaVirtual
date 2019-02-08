using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IProductosServices
    {
        Task<IEnumerable<Producto>> GetAll();
    }
}
