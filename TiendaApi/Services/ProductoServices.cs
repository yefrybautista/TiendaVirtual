using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public interface IProductoServices
    {
        Producto Get(int id);
        IEnumerable<Producto> GetAll();
        bool Add(Producto producto);
        bool Update(Producto producto);
        bool Delete(int id);
    }
    
    public class ProductoServices: IProductoServices
    {
        private readonly TiendaContext db;

        public ProductoServices(TiendaContext _tiendaContext)
        {
            db = _tiendaContext;
        }
        public Producto Get(int id)
        {
            var producto = new Producto();
            try
            {
                producto = db.Productos.Find(id);
               
            }
            catch (Exception)
            {

            }
            return producto;
        }
        public IEnumerable<Producto> GetAll()
        {
            var productos = new List<Producto>();
            try
            {
                productos = db.Productos.ToList();
            }
            catch (Exception)
            {

            }
            return productos;
        }

        public bool Add(Producto producto)
        {
            try
            {
                db.Productos.Add(producto);
                db.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }
        public bool Update(Producto producto)
        {
            try
            {
                db.Productos.Update(producto);
                db.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }
        public bool Delete(int id)
        {
            try
            {
                var producto = db.Productos.Find(id);
                db.Productos.Remove(producto);
                db.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }
    }
}
