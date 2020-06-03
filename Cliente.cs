using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas
{
    public class Cliente
    {
        public string Nombre { get; set; }

        public List<Producto> Productos { get; set; } = new List<Producto>();

        public Cliente(string nombre)
        {

            this.Nombre = nombre;
        }
    }
}
