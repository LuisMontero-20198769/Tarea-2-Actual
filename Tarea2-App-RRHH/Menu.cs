using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_App_RRHH
{
    public class Menu
    {
        int opcion; //variable declarada
        public void Presentacion()
        {
            
            do
            {
                Console.Clear();//Limpiar la pantalla...
                Console.ForegroundColor = ConsoleColor.Yellow;
                //Menu principal de la Empresa Service Power Montero & Asoc.
                Console.WriteLine("***** RECURSOS HUMANOS ***** \n");
                Console.WriteLine("\n Menu Principal:");
                Console.WriteLine("\n1) Crear empleado de tiempo Completo.");
                Console.WriteLine("2) Crear empleado de Medio tiempo.");
                Console.WriteLine("3) Crear empleado temporero");
                Console.WriteLine("5) Salir.\n");
                Console.WriteLine("Eliga la opcion deseada: ");
                Console.ResetColor();

                opcion = int.Parse(Console.ReadLine());//Aqui se lee el valor de la variable

                if (opcion == 5)
                {
                    Console.Clear();//limpiador de pantalla....
                    Console.WriteLine("\n Ha colminado el servicio. Vuelva pronto!");
                    Console.WriteLine("\n Press 'ENTER' para cerrar ventana....");
                    Environment.Exit(0);//Metodo que cierra el programa.
                }
                IEmpleado select = Factory.Opciones(opcion);
                select.CrearEmpleado();
                Console.ReadKey();

            } while (opcion != 0); //Condicion para finalizar el ciclo do-while (hacer-mientras)

        }
    }
}
