using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas
{
    class ProductosVendidos
    { 
        public void ImprimirFactura()
        {
            Console.Clear();

            Console.WriteLine("Ingrese el nombre del Cliente: ");
            string nombre = Console.ReadLine();
            for (var cliente = 0; cliente < Repositorio.Instancia.facturas.Count; cliente++)
            {

                
                




            }
            





        }



        public void Read() 
        
        {
           
            

        }
        public Factura GetByIndex(int index)
        {
            return Repositorio.Instancia.facturas[index];
        }

    }
}
