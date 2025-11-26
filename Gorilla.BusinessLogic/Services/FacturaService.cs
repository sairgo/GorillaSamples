using Gorilla.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorilla.BusinessLogic.Services
{
    public class FacturaService
    {
        private const decimal TasaImpuesto = 0.19m;

        public Factura CalcularTotales(Factura factura)
        {
            if (factura == null)
                throw new ArgumentNullException(nameof(factura));

            var totalBruto = factura.Detalles.Sum(d => d.Subtotal);
            var impuesto = Math.Round(totalBruto * TasaImpuesto, 2);
            var totalNeto = totalBruto + impuesto;

            factura.TotalBruto = totalBruto;
            factura.Impuesto = impuesto;
            factura.TotalNeto = totalNeto;

            return factura;
        }

        public Factura CrearFacturaDemo()
        {
            var factura = new Factura
            {
                Numero = "FAC-0001",
                Fecha = DateTime.Today,
                Cliente = "Cliente de prueba"
            };

            factura.Detalles.Add(new DetalleFactura
            {
                Linea = 1,
                Descripcion = "Servicio de reencauche",
                Cantidad = 4,
                PrecioUnitario = 250000
            });

            factura.Detalles.Add(new DetalleFactura
            {
                Linea = 2,
                Descripcion = "Balanceo",
                Cantidad = 4,
                PrecioUnitario = 60000
            });

            return CalcularTotales(factura);
        }
    }
}
