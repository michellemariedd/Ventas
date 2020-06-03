using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas
{
    public class MenuPrincipal
    {
        enum OptionMenu
        {
            MAN_Pro = 1,
            MAN_Cli,
            REA_VEN,
            VENTAS,
            EXIT

        }
        public void ImprimirMenu()
        {
            MenuProductos menuProductos = new MenuProductos();
            MenuClientes menuClientes = new MenuClientes();
            ServicioVentas servicioVentas = new ServicioVentas();
            ProductosVendidos vendidos = new ProductosVendidos();
           
            
            try
            {
                Console.Clear();
                Console.WriteLine(" ***Colmado*** ");
                Console.WriteLine(" 1-Mantenimiento productos\n 2-Mantenimiento clientes\n 3-Realizar ventas\n 4-Ventas\n 5-Salir");
                int option = Convert.ToInt32(Console.ReadLine());


                switch (option)
                {
                    case (int)OptionMenu.MAN_Pro:
                        menuProductos.ImprimirMenu();
                        break;
                    case (int)OptionMenu.MAN_Cli:
                        menuClientes.ImprimirMenu();
                        break;
                    case (int)OptionMenu.REA_VEN:
                        servicioVentas.Vender();
                        break;
                    case (int)OptionMenu.VENTAS:
                        vendidos.ImprimirFactura();
                        break;
                    case (int)OptionMenu.EXIT:
                        Console.WriteLine("Gracias por utilizar el sistema.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Debe introducir una opcion valida.");
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
