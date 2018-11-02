using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services;
using Services.Implementations;
using Services.Interfaces;

namespace ProductosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProductosController : ControllerBase
    {
        private readonly IGenericServices<Producto> productoServices;
        public ProductosController(IGenericServices<Producto> _productoServices)
        {
            productoServices = _productoServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                productoServices.GetAll()
                );
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(
                productoServices.Get(id)
                );
        }
        [HttpPost]
        public IActionResult Add([FromBody] Producto producto)
        {
            return Ok(
                productoServices.Add(producto)
                );
        }
        [HttpPut("{id}")]
        public IActionResult Update(Producto producto)
        {
            return Ok(
                productoServices.Update(producto, producto.IdProducto)
                );
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) =>  Ok(productoServices.Delete(id));

    }
}