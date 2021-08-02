using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    class EJERCICIO4
    {
        static void Main(string[] args)
        {
            //DECLARACION DE VARIABLES
            double C, f;

            //INGRESO DE DATOS 
            Console.WriteLine("INGRESE LA CANTIDAD DE GRADOS CENTIFRADOS A CONVERTIR: ");
            C = Convert.ToDouble(Console.ReadLine());

            // FORMULA DE CONVERSION DE GRADOS CENTIGRADOS A FAHRENHEIT
            f = (9 / 5) * C + 32;

            //SALIDA DE DATOS 
            Console.WriteLine("LOS GRADOS CONVERTIDOS A FAHRENHEIT SON: ", +f);
            Console.ReadKey();
            Console.Write("PULSA CUALQUIER LETRA PARA SALIR:");
            Console.ReadKey();

        }
    }
}
