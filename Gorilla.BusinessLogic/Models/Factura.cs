using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorilla.BusinessLogic.Models
{
    public class Factura
    {
        public string Numero { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; } = string.Empty;
        public List<DetalleFactura> Detalles { get; set; } = new();
        public decimal TotalBruto { get; set; }
        public decimal Impuesto { get; set; }
        public decimal TotalNeto { get; set; }
    }
}
