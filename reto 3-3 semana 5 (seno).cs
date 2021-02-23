using System;

namespace reto_3_3_semana_5__seno_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el seno: ");
            double x = double.Parse(Console.ReadLine());
            double sin = 0;
            int n = 100;


            for (int i = 0; i <= n; i++)
            {
                sin += ((Math.Pow(-1, i) / Factorial(2 * i + 1)) * Math.Pow(x, 2 * i + 1));
                Console.WriteLine("el seno es: " + sin);
            }



        }
        static double Factorial(double valor)
        {
            double total = 1;
            for (int cont = 1; cont <= valor; cont++)
            {
                total *= cont;
            }
            return total;
        }


        //https://youtu.be/wtTBUF7wqmc
    }
}
