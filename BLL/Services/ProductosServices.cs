using BLL.Services.Interfaces;
using DAL.Models;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductosServices: IProductosServices
    {
        private readonly IUnitOfWork _uow;
        public ProductosServices(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Producto>> GetAll()
        {
            try
            {
                var productos = await _uow.ProductoRepository.GetAll();
                return productos;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        
        public async Task<Producto> GetById(int id)
        {
            try
            {
                var producto = await _uow.ProductoRepository.GetById(id);
                return producto;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Producto> Add(Producto producto)
        {
            try
            {
                _uow.ProductoRepository.Add(producto);
                await _uow.SaveChangesAsync();
                return producto;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        
    }
}
