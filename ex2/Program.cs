using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intervalo 10 e 20");
            Console.WriteLine("-----------------");

            int n = 0;
            int intervalo = 0;

            int i = 1;
            while (i <= 7)
            {
                Console.Write("Digite o " + i + "º numero: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n >= 10 && n <= 20)
                {
                    intervalo++;
                }
        
                i++;
            }
            Console.WriteLine("Qtde numeros no intervalo de 10 e 20: " + intervalo);
            Console.ReadKey();
        }
    }
}
