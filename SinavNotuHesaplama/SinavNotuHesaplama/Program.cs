using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavNotuHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vize Notunu Giriniz: ");
            double vizeNotu = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Final Notunu Giriniz: ");
            double FinalNotu = Convert.ToDouble(Console.ReadLine());

            double ortalamaNotu = (vizeNotu * 0.4) + (FinalNotu * 0.6);

            string harfNotu;

            if (ortalamaNotu >= 95)
            {
                harfNotu = "AA";
            }
            else if (ortalamaNotu >= 85)
            {
                harfNotu = "BA";
            }

            else if(ortalamaNotu >= 80)
            {
                harfNotu = "BB";
            }

            else if (ortalamaNotu >= 75)
            {
                harfNotu = "CB";
            }

        else if (ortalamaNotu >= 70)
            {
                harfNotu = "CC";
            }

            else if (ortalamaNotu >= 65)
            {
                harfNotu = "DC";
            }

            else if (ortalamaNotu >= 60)

            {
                harfNotu = "CC";
            }

            else if (ortalamaNotu >= 50)
            {
                harfNotu = "FD";
            }

            else 
            {
                harfNotu = "FF";
            }

            Console.WriteLine("Ortalama notunuz: {0}",ortalamaNotu);
            Console.WriteLine("Harf notunuz: {0}",harfNotu);
            Console.ReadLine();
        }
    }
}
