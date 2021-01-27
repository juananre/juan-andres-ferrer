using System;

namespace reto_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ingresos de datos 

            Console.Write("angulo d:");
            double Ad = double.Parse(Console.ReadLine());
            Console.Write("ingrese x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("ingrese w:");
            double w = double.Parse(Console.ReadLine());

            //calculo de datos 

            double rad = Ad * Math.PI / 180;

            double xy = Math.Cos(rad) * w;
            double y = xy - x;

            //salida de datos 

            Console.WriteLine("el lado y es: " + y);

            //https://youtu.be/koRUymJlbZ0
        }
    }
}
