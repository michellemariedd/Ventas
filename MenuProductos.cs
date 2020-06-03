using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas
{
    enum opciones
    {
        ADD = 1,
        EDIT,
        DELETE,
        READ,
        BACK

    }
    public class MenuProductos
    {
        public void ImprimirMenu()
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            ServicioProductos servicioProductos = new ServicioProductos();
            try
            {
                Console.Clear();
                Console.WriteLine(" ***Productos*** ");
                Console.WriteLine(" 1-Agregar\n 2-Editar\n 3-Eliminar\n 4-Listar\n 5-Volver");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case (int)opciones.ADD:
                        servicioProductos.Add();
                        break;
                    case (int)opciones.EDIT:
                        servicioProductos.Edit();
                        break;
                    case (int)opciones.DELETE:
                        servicioProductos.Delete();
                        break;
                    case (int)opciones.READ:
                        servicioProductos.Read(true);
                        break;
                    case (int)opciones.BACK:
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
