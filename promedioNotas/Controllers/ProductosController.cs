using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace promedioNotas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private static List<Productos> _productos = new List<Productos>
        {
            new Productos { Id = 1, Nombre = "Producto 1", Precio = 10.99m },
            new Productos { Id = 2, Nombre = "Producto 2", Precio = 20.99m }
        };

        [HttpDelete("ListadoProductos/{id}")]
        public IActionResult Delete(int id)
        {
            var productoExistente = _productos.Find(p => p.Id == id);

            if (productoExistente == null)
            {
                return NotFound();
            }

            _productos.Remove(productoExistente);

            return NoContent();
        }
    }

    public class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}
