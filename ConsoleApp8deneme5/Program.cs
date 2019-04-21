using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8deneme5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            if (0 < a)
            {
                Console.WriteLine("pozitif");
            }
            if (0>a)
            {
                Console.WriteLine("negatif");
            }Console.ReadLine();
        }
	

	}
}

