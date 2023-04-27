using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SUMATORIA DE LOS NUMEROS PARES DEL 2 AL 2000");
            int suma = 0;
            try
            {
                for (int i = 2; i <= 2000; i++)
                {
                    if (i % 2 == 0)
                    {
                        suma = suma + i;

                    }

                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
            Console.WriteLine("La sumatoria de los numeros pares del 2 al 2000 es de:" + suma);
            Console.ReadKey();
        }
    }
}
