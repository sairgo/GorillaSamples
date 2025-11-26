using Gorilla.WinFormsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorilla.WinFormsDemo.Services
{
    public class ProductoService
    {
        public List<Producto> ObtenerProductosDemo()
        {
            return new List<Producto>
            {
                new Producto { Id = 1, Nombre = "Llanta 195/60 R15", Categoria = "Reencauche", Precio = 250000, Stock = 12 },
                new Producto { Id = 2, Nombre = "Llanta 205/55 R16", Categoria = "Reencauche", Precio = 280000, Stock = 5 },
                new Producto { Id = 3, Nombre = "Servicio alineación", Categoria = "Servicio", Precio = 80000, Stock = 0 },
                new Producto { Id = 4, Nombre = "Servicio balanceo", Categoria = "Servicio", Precio = 60000, Stock = 0 }
            };
        }

        public List<Producto> FiltrarPorCategoria(IEnumerable<Producto> productos, string categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria))
                return productos.ToList();

            return productos
                .Where(p => p.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
