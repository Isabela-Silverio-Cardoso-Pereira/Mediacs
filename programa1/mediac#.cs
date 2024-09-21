using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa1
{
    internal class Program
    {
        static void Main(string[] args)
        {


           double A = Convert.ToDouble(Console.ReadLine());
           double B = Convert.ToDouble(Console.ReadLine());
            double multiplicacao1 = A * 3.5;
            double multiplicacao2 = B * 7.5;
            double soma = multiplicacao1 + multiplicacao2;
            double pesos = 3.5 + 7.5;
            double MEDIA = soma / pesos;
            Console.WriteLine(MEDIA.ToString("F4"));


        }
    }
}
