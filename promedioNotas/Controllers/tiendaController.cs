using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace promedioNotas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tiendaController : ControllerBase
    {
        private static List<Producto> _productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Producto 1", Precio = 10.99m },
            new Producto { Id = 2, Nombre = "Producto 2", Precio = 20.99m }
        };

        [HttpPut("ListadoProductos/{id}")]
        public IActionResult Put(int id, Producto productoActualizado)
        {
            var productoExistente = _productos.Find(p => p.Id == id);

            if (productoExistente == null)
            {
                return NotFound();
            }

            productoExistente.Nombre = productoActualizado.Nombre;
            productoExistente.Precio = productoActualizado.Precio;

            return NoContent();
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}
