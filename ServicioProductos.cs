using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas
{
    public class ServicioProductos
    {
        private MenuProductos menuP;

        public ServicioProductos()
        {
            menuP = new MenuProductos();
        }
        public void Add()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del producto: ");
            int precio = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingrese la cantidad  del producto: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Producto nuevoProducto = new Producto(nombre, precio, cantidad);

            Repositorio.Instancia.productos.Add(nuevoProducto);
            Console.WriteLine("Se ha agregado con exito");
            Console.ReadKey();
            menuP.ImprimirMenu();


        }
        public void Edit()
        {
            try

            {
                Console.Clear();
                Read();
                Console.WriteLine("Seleccione el producto que desea editar: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre del producto: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el precio del producto: ");
                int precio = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Ingrese la cantidad  del producto: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                Producto productoEdit = new Producto(nombre, precio, cantidad);

                Repositorio.Instancia.productos[opcion - 1] = productoEdit;

                Console.WriteLine("Se ha agregado con exito");
                Console.ReadKey();
                menuP.ImprimirMenu();
            }

            catch (Exception e)
            {
                Console.WriteLine("Debe seleccionar una opcion valida.");
                Console.ReadKey();
                Edit();
            }
        }

       
        public void Delete()
        {
            try
            {
                Console.Clear();
                Read();

                Console.WriteLine("Seleccione el producto que desea eliminar:");
                int opcion = Convert.ToInt32(Console.ReadLine());

                Repositorio.Instancia.productos.RemoveAt(opcion - 1);

                menuP.ImprimirMenu();
            }
            catch (Exception e)
            {
                Console.WriteLine("Debe  seleccinar una opcion valida.");
                Console.ReadKey();
                Delete();

            }
        }
        public void Read(bool isWait = false)
        {
            Console.Clear();
            int interator = 1;

            foreach (Producto item in Repositorio.Instancia.productos)
            {
                Console.WriteLine(interator + "-" + item.Nombre + "\n *Precio:" + item.Precio + "\n *Productos disponibles:" + item.Cantidad );
                interator++;
            }
            if (isWait)
            {
                Console.ReadKey();
                menuP.ImprimirMenu();
            }
        }
        public Producto GetByIndex(int index)
        {
            return Repositorio.Instancia.productos[index];
        }

        public void AsignarProducto(int indexClient, Producto producto)
        {
            Repositorio.Instancia.clientes[indexClient].Productos.Add(producto);
        }

    }
}
