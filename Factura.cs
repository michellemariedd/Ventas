using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas
{
    public class Factura
    {

        string NombreCliente;
        string ProductoVendido;
        int Cantidad;
        int Precio;

        public Factura(string nombreCliente, string productoVendido, int cantidad, int precio)
        {
            this.NombreCliente = nombreCliente;
            this.ProductoVendido = productoVendido;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

       

    }  }
