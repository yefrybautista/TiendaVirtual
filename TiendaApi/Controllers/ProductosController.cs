using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services;

namespace ProductosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoServices productoServices;
        public ProductosController(IProductoServices _productoServices)
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
        [HttpPut]
        public IActionResult Update(Producto producto)
        {
            return Ok(
                productoServices.Update(producto)
                );
        }
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            return Ok(
                productoServices.Delete(id)
                );
        }

    }
}