using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas
{
    public class Producto
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }

        public List<Cliente> clientes { get; set; } = new List<Cliente>();

        public Producto(string nombre, int precio, int cantidad)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;

        }
    }
}
