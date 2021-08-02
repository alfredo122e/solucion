using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    class EJERCICIO3
    {
        static void Main(string[] args)
        {
			// Crear un programa que pida al usuario dos números enteros. 
			// Si el segundo no es cero, mostrará el resultado de dividir entre el primero y el segundo.
			// Por el contrario, si el segundo número es cero, escribirá "Error: No se puede dividir entre cero".

			Console.WriteLine("Introduzca el primer numero");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Introduzca el segundo numero");
			int num2 = int.Parse(Console.ReadLine());
			if (num2 == 0)
			{
				Console.WriteLine("Error, no se puede dividir entre cero");
			}

			else
			{
				int resultado = num1 / num2;
				Console.WriteLine("El resultado es " + resultado);
			}

			Console.ReadLine();
		}
    }
}
