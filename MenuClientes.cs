using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas
{
    enum Opciones
    {
        ADD = 1,
        EDIT,
        DELETE,
        READ,
        BACK
    }
    public class MenuClientes
    {
        public void ImprimirMenu()
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            ServicioCliente servicioCliente = new ServicioCliente();
            try

            {
                Console.Clear();
                Console.WriteLine(" ***Clientes*** ");
                Console.WriteLine(" 1-Agregar\n 2-Editar\n 3-Eliminar\n 4-Listar\n 5-Volver");
                int Opcion = Convert.ToInt32(Console.ReadLine());

                switch (Opcion)
                {
                    case (int)Opciones.ADD:
                        servicioCliente.Add();
                        break;
                    case (int)Opciones.EDIT:
                        servicioCliente.Edit();
                        break;
                    case (int)Opciones.DELETE:
                        servicioCliente.Delete();
                        break;
                    case (int)Opciones.READ:
                        servicioCliente.Read(true);
                        break;
                    case (int)Opciones.BACK:
                        menuPrincipal.ImprimirMenu();
                        break;
                    default:
                        Console.WriteLine("Debe introducir una opcion valida");
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Debe introducir una opcion valida");
                Console.ReadKey();
                ImprimirMenu();
            }
        }
    }
}
