using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas
{
    public sealed class Repositorio
    {
        public List<Producto> productos { get; set; } = new List<Producto>();

        public List<Cliente> clientes { get; set; } = new List<Cliente>();

        public List<Factura> facturas { get; set; } = new List<Factura>();

        public static Repositorio Instancia { get; } = new Repositorio();

        private Repositorio()
        {
        }


    }
}
