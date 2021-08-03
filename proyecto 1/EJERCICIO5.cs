using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    class EJERCICIO5
    {
        

        static void Main(string[] args)
        {
            double costo = 0;
            int medicina = 0;

            string valor = "";

            double total = 0;
            double iva = 0;
            double granTotal = 0;

            Console.WriteLine("Dame el costo del producto:");
            valor = Console.ReadLine();
            costo = Convert.ToDouble(valor);

            Console.WriteLine("Es medicamento? Escribe 1 para si, 2 para no");
            valor = Console.ReadLine();
            medicina = Convert.ToInt32(valor);

            iva = Math.Round(costo * 0.13,2);

            granTotal = costo + iva;

            if (medicina != 2 )
            {
                Console.WriteLine("============================================== ");
                Console.WriteLine("Su producto no incluye IVA ");
                Console.WriteLine("El precio total es igua a:     {0} ", costo);
                Console.WriteLine("============================================== ");

            }
                
            else if (medicina != 1 )
            {
                Console.WriteLine("============================================== ");
                Console.WriteLine("El iva de este producto es igual a:   {0} ", iva);
                Console.WriteLine("Costo del producto es igual:          {0} ", costo);
                Console.WriteLine("El precio total es igual a:           {0} ", granTotal);
                Console.WriteLine("============================================== ");
            }




            Console.ReadKey();

        }
    }
}
