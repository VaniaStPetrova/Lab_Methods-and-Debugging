using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int chisloVhodPrograma = Math.Abs(int.Parse(Console.ReadLine()));
            int izhodRezultat4etni = VzemiUmnojeno4etnoIliNe4etno(chisloVhodPrograma);
            Console.WriteLine(izhodRezultat4etni);
        }

        public static int VzemiUmnojeno4etnoIliNe4etno(int a)
        {
            int poslednaCifra = 0;
            int finalRezult4etni = 0;
            int finalRezultNe4etni = 0;
            while (a > 0)
            {
                poslednaCifra = a % 10;
                a = a / 10;
                if (poslednaCifra % 2 == 0)
                {
                    finalRezult4etni = finalRezult4etni + poslednaCifra;
                }
                else
                {
                    finalRezultNe4etni = finalRezultNe4etni + poslednaCifra;
                }
            }
            return finalRezult4etni * finalRezultNe4etni;
        }
    }
}
