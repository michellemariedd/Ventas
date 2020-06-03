using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas
{
    public class ServicioCliente
    {
        private MenuClientes menuc;

        public ServicioCliente() => menuc = new MenuClientes();

        public void Add()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del cliente:");
            string nombre = Console.ReadLine();

            Cliente nuevoCliente = new Cliente(nombre);

            Repositorio.Instancia.clientes.Add(nuevoCliente);
            Console.WriteLine("Se ha agregado con exito");
            Console.ReadKey();

            menuc.ImprimirMenu();


        }
        public void Edit()
        {
            try
            {
                Console.Clear();
                Read();

                Console.WriteLine("Selecione el cliente que desea editar");
                int opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre del cliente: ");
                string nombre = Console.ReadLine();

                Cliente clientEditado = new Cliente(nombre);
                Repositorio.Instancia.clientes[opcion - 1] = clientEditado;

                menuc.ImprimirMenu();
            }
            catch (Exception e)
            {
                Console.WriteLine("Debe seleccionar una opcion Valida");
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
                Console.WriteLine("Seleccione el cliente que desea editar");
                int opcion = Convert.ToInt32(Console.ReadLine());

                Repositorio.Instancia.clientes.RemoveAt(opcion - 1);

                menuc.ImprimirMenu();
            }
            catch (Exception e)
            {
                Console.WriteLine("Debe seleccionar una opcion Valida");
                Console.ReadKey();
                Delete();
            }
        }
        public void Read(bool isWait = false)
        {
            Console.Clear();
            int interator = 1;
            foreach (Cliente item in Repositorio.Instancia.clientes)
            {
                Console.WriteLine(interator + "-" + item.Nombre);
                interator++;

            }
            if (isWait)
            {
                Console.ReadKey();
                menuc.ImprimirMenu();
            }
        }


        public Cliente GetByIndex(int index)
        {
            return Repositorio.Instancia.clientes[index];
        }

        internal void VenderProductos(Producto productoAsignado)
        {
            throw new NotImplementedException();
        }

        internal void VenderProductos(int v, Producto productoAsignado)
        {
            throw new NotImplementedException();
        }
    }
}
