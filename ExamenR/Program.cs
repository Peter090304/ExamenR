using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenR
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int numero = 10;

            Console.WriteLine("Tabla de multiplicar del 10:");
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }

            Console.WriteLine("Entrada no valida.Por favor, ingrese un numero entero.");

            {
                Console.WriteLine("Por favor, ingrese su CURP:");
                string curp = Console.ReadLine();

                if (ValidarCURP(curp))
                {
                    Console.WriteLine("CURP válida: " + curp);
                }
                else
                {
                    Console.WriteLine("La CURP ingresada no es válida.");
                }
            }

            static bool ValidarCURP(string curp)
            {

                return true;
            }
        }
```
    }

}


        /*{
              Console.WriteLine("Ingrese el numero de inicio del intervalo:");
              int inicio = int.Parse(Console.ReadLine());
              Console.WriteLine("Ingrese el numero de fin del intervalo:");
              int fin = int.Parse(Console.ReadLine());
              if (inicio == fin)
              {
                  Console.WriteLine("Losnumeros ingresados son iguales.");
              }
              else
              {
                  int paso = (inicio < fin) ? 1 : -1;
              }
              for (int numero = inicio; numero != fin + paso; numero += paso)
              {
                  Console.WriteLine($"La secuencia de los numeros es {numero}");
              }*/






    
























   

                
           








    