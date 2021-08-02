using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_solucion_de_ejercicios_basicos
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            // declaracion de variables 
            double C, f;

            //Ingreso de datos
            Console.WriteLine("Ingrese la cantidad de Grados Centigrados: ");
            C = Convert.ToDouble(Console.ReadLine());


            //conversion de grados centigrados a Fahrenheit
            f = (9 / 5) * C + 32;


            //salida de datos 
            Console.WriteLine("Loa Grados Fahrenheit son: " + f);
            Console.ReadKey();


        }
    }
}



