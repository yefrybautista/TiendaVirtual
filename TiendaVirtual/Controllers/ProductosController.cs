using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TiendaVirtual.Controllers
{
    [Produces("application/json")]
    [Route("api/Productos")]
    public class ProductosController : Controller
    {
        private readonly IProductosServices _productosServices;
        public ProductosController(IProductosServices productosServices)
        {
            _productosServices = productosServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var productos = await _productosServices.GetAll();
                return Ok(productos);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}