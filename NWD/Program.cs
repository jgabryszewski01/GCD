using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWD
{
    class Program
    {
        static void Main(string[] args)
        {
            int roznica;
            Console.WriteLine("Podaj wartosc m: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartosc n: ");
            int n = int.Parse(Console.ReadLine());

            do
            {
                if (m > n)
                {
                    roznica = m - n;
                    m = roznica;
                }
                else
                {
                    roznica = n - m;
                    n = roznica;
                }
            } while (roznica != 0);

            if (m > n) { Console.WriteLine("Najwiekszy wspolny dzielnik podanych liczb to " + m); }
            else { Console.WriteLine("Najwiekszy wspolny dzielnik podanych liczb to " + n); }
        }
    }
}
