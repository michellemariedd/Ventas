using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas
{
    public class ServicioVentas
    {
        private ServicioProductos servicioProductos;
        private ServicioCliente servicioCliente;
        private MenuPrincipal menuPrincipal;
        private ProductosVendidos vendidos;

        public object productosVendidos { get; private set; }

        public ServicioVentas()
        {
            vendidos = new ProductosVendidos();
            servicioProductos = new ServicioProductos();
            servicioCliente = new ServicioCliente();
            menuPrincipal = new MenuPrincipal();
        }

        public void Vender()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del Cliente: ");
            string nombreCliente = Console.ReadLine();
            for (var cliente = 0; cliente < Repositorio.Instancia.clientes.Count; cliente++)
            {
                if (Repositorio.Instancia.clientes[cliente].Nombre == (nombreCliente))
                {
                    Console.Clear();
                    Console.WriteLine(Repositorio.Instancia.clientes[cliente].Nombre);
                    Console.ReadKey();

                    
                }
                else
                {
                    Console.WriteLine("Ese cliente no existe.");
                    Console.ReadKey();
                    Console.WriteLine("Desea buscar otro cliente? s/n");
                    string opcion = Console.ReadLine();
                    if (opcion == "s")
                    {
                        Vender();
                    
                    }
                    else 
                    {
                        menuPrincipal.ImprimirMenu();
                    }
                    

                }
            }
            VenderProductos(nombreCliente);
        }
        private void VenderProductos(string indexCliente)
        {
            Console.WriteLine("Ingrese el nombre del Producto: ");
            string indexProducto = Console.ReadLine();
            
            for (var producto = 0; producto < Repositorio.Instancia.productos.Count; producto++)
            {
                
                if (Repositorio.Instancia.productos[producto].Nombre == (indexProducto))
                {
                    
                    Console.WriteLine(Repositorio.Instancia.productos[producto].Nombre);

                    Console.ReadKey(); 

                    
                }
                else
                {
                    Console.WriteLine("Producto no disponible.");
                    Console.ReadKey();
                    Console.WriteLine("Desea buscar otro producto? s/n");
                    string opcion = Console.ReadLine();
                    if (opcion == "s")
                    {
                        VenderProductos(indexCliente);

                    }
                    else
                    {
                        menuPrincipal.ImprimirMenu();
                    }
                }
               
            }
             
            Console.WriteLine("Introduzca la cantidad  de producto que desea vender: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            for (var producto = 0; producto < Repositorio.Instancia.productos.Count; producto++)
            {
                if (Repositorio.Instancia.productos[producto].Cantidad == (cantidad))
                {

                    Console.WriteLine(Repositorio.Instancia.productos[producto].Nombre);
                    Console.WriteLine(Repositorio.Instancia.productos[producto].Cantidad);
                    Console.WriteLine(Repositorio.Instancia.productos[producto].Precio);

                    Console.ReadKey();
                  
                }
               else  if (Repositorio.Instancia.productos[producto].Cantidad > (cantidad))
                {
                    Console.WriteLine("No tiene suficientes productos.");
                    Console.ReadKey();
                    Console.WriteLine("Desea agregar otra cantidad? s/n");
                    string opcion = Console.ReadLine();
                    if (opcion == "s")
                    {
                        VenderProductos(indexCliente);

                    }
                    else
                    {
                        menuPrincipal.ImprimirMenu();
                    }

                }
               else if (Repositorio.Instancia.productos[producto].Cantidad < (cantidad))
                {
                    Console.WriteLine("No tiene suficientes productos.");
                    Console.ReadKey();
                    Console.WriteLine("Desea agregar otra cantidad? s/n");
                    string opcion = Console.ReadLine();
                    if (opcion == "s")
                    {
                        VenderProductos(indexCliente);

                    }
                    else
                    {
                        menuPrincipal.ImprimirMenu();
                    }
                    
                }
            }
            
        }
    }
}