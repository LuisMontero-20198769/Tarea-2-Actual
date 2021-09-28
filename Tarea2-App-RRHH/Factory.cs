using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_App_RRHH
{
    public class Factory
    {
        //Implementacion del patron Factory o Fabrica
        public static IEmpleado Opciones(int opcion)
        {
            switch (opcion)
            {
                //case 1:
                //    return new EmpleadoCompleto();
                //     break;

                case 1:
                    return new EmpleadoMedio();
                default:
                    Console.WriteLine("TIPO DE EMPLEADO INEXISTENTE!!");
                    break;

                    //case 3:
                    //    return new EmpleadoTemporero();
                    //    break;
            }
            return null;

        }
    }
}
