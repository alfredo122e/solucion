﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_solucion_de_ejercicios_basicos
{
    class Ejercicio2
    {
        private static void Main(string[] args)
        
            {
            int NUM1, NUM2, RESUL;
        String linea;
        Console.Write("Primer Numero: ");
        linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.Write("Segundo Numero: ");
            linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            Console.WriteLine();
            RESUL = NUM1 + NUM2;
            Console.WriteLine("El resultado de Tu Suma Es {0}: ", RESUL);
            RESUL = NUM1 - NUM2;
            Console.WriteLine("El resultado de Tu Resta Es :{0} - {1} = {2} ", NUM1, NUM2, RESUL);
            RESUL = NUM1 * NUM2;
            Console.WriteLine("El resultado de Tu Multiplicacion Es: " + RESUL);
            Console.Write("Pulse una Tecla:"); Console.ReadLine();

        }
    }

}
 