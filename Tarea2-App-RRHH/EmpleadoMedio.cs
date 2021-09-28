using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_App_RRHH
{
    public class EmpleadoMedio: IEmpleado
    {

        //Atributos
        private string nombre, department, cargo;
        private int num_cuenta;
        private int hors = 4;
        private double precioHora =300;
        private double salary;
        //------
        public string Nombre { get => nombre; set => nombre = value; }
        public string Department { get => department; set => department = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int NumCuenta { get => num_cuenta; set => num_cuenta = value; }
        public double Salary { get => salary; set => salary = value; }
        //-----
       
        public void CrearEmpleado()
        {
            Console.WriteLine("******* CREAR EMPLEADO DE TIEMPO MEDIO ******\n");
            Random aleatorio = new Random();
            num_cuenta = aleatorio.Next(1000, 10000);
            Console.WriteLine("Su numero de cuenta es: "+num_cuenta);
            Console.WriteLine("Cual es su nombre?");
            nombre = Console.ReadLine();
            Console.WriteLine("\nCual es su cargo?");
            cargo = Console.ReadLine();
            Console.WriteLine("\nCual es su departamento?");
            department = Console.ReadLine();
            EmpleadoCreado();

        }
        public void EmpleadoCreado()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"*** EMPLEADO DE MEDIO TIEMPO CREADO ***\n" +
                $"=> Numero cuenta: #{num_cuenta} \n" +
                $"=> Nombre: {nombre} \n"+
                $"=> Cargo: {cargo} \n"+
                $"=> Departamento: {department} \n"+
                $"=> Salario: RD${salary}");
            Console.ResetColor();
        }
         

        private double calcularPago()
        {
       
            salary = hors * precioHora;
            return salary;
        }
        
    }
}
