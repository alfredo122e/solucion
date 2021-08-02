using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    class EJERCICIO2
    {
        static void Main(string[] args)
        {
            int a, b, resultado1, resultado2;
            Console.WriteLine("Ingrese el primer Valor:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo Valor:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            resultado1 = (a + b) * (a - b);
            resultado2 = a * 2 - b;
            Console.WriteLine("RESULTADO DE (a + b) * (a - b) = " + resultado1);
            Console.WriteLine("REULTADO DE a2 -b = " + resultado2);

            Console.ReadKey();
        }
    }
}

