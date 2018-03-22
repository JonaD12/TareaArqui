using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bienvenido al sistema de calculo de corriente para iniciar digite si, para salir digite no");
                string x = Console.ReadLine();
                while (x != "no")
                {
                    Console.WriteLine("Ingrese su voltaje de la bateria");
                    double voltaje = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese su Resistencia");
                    double resistencia = double.Parse(Console.ReadLine());
                    double corriente = voltaje / resistencia;
                    Console.WriteLine("la corriente de la bateria es: " + corriente);
                    Console.WriteLine("Desea realiazar otra prueba? (si, para continuar, no para salir)");
                     x = Console.ReadLine();
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Por favor solo ingrese numeros");
                Console.ReadKey();
            }

        }
    }
}
