using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    class EJERCICIO6
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, porcentaje1, porcentaje2, porcentaje3, notafinal1;
            Console.WriteLine("INGRESE LA PRIMER NOTA (30%): ");
            nota1 = int.Parse(Console.ReadLine());
            porcentaje1 = (nota1 * 0.30);
            Console.WriteLine("su nota ingresada es de: " + nota1);
            Console.WriteLine("su nota con el 30% es de: " + porcentaje1);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("ingrese la segunda nota (35%): ");
            nota2 = int.Parse(Console.ReadLine());
            porcentaje2 = (nota2 * 0.35);
            Console.WriteLine("su nota ingresada es de: " + nota2);
            Console.WriteLine("su nota con el 30% es de: " + porcentaje2);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("ingrese la segunda nota (25%): ");
            nota3 = int.Parse(Console.ReadLine());
            porcentaje3 = (nota3 * 0.25);
            Console.WriteLine("su nota ingresada es de: " + nota3);
            Console.WriteLine("su nota con el 30% es de: " + porcentaje3);
            Console.WriteLine("------------------------------------");
            notafinal1 = (porcentaje1 + porcentaje2 + porcentaje3);
            Console.WriteLine("Nota final es de: "+ notafinal1);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("NOTA: los porcentajes dandos en la tarea suman 90%");


            Console.WriteLine("pulse para uan tecla para salir ");
            Console.ReadKey();
        }
    }
}
