using System;
using System.Globalization;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equação do segundo grau");
            double a, b, c, delta, x1, x2;
            Console.WriteLine("escreva o valor de A ");
            a = double.Parse(Console.ReadLine()!,CultureInfo.InvariantCulture);
            Console.WriteLine("escreva o valor de B ");
            b = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.WriteLine("escreva o valor de C ");
            c = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            delta = Math.Pow(b, 2.0) - 4 * a * c;
            Console.WriteLine("O valor de delta é : " + delta.ToString("F2", CultureInfo.InvariantCulture));

            if (a == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel de calcular! ");
            }
            else {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("O valor de x1 é : " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("O valor de x2 é : " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }          
            
            

            Console.ReadLine();
        }
    }
}