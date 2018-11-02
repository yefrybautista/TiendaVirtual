using Model;
using Persistence;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Implementations
{
    public class GenericServices<T> : IGenericServices<T> where T : class
    {
        private readonly TiendaContext _context;
        public GenericServices(TiendaContext context)
        {
            _context = context;
        }

        public bool Add(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ) {

                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var datos = _context.Set<T>().Find(id);
                _context.Set<T>().Remove(datos);
                _context.SaveChanges();

                return true;
            }
            catch (Exception )
            {

                return false;
            }
        }

        public T Get(int id)
        {
            var datos = _context.Set<T>().Find(id);
            return datos;
        }

        public IEnumerable<T> GetAll()
        {
            var data = new List<T>();
            try
            {
                data = _context.Set<T>().ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return data;
        }

        public bool Update(T entity, int Id)
        {
            try
            {
                var data = _context.Set<T>().Find(Id);
                data = entity;
                _context.SaveChanges();
                return true;
            }
            catch (Exception )
            {

                return false;
            }

        }
    }
}

