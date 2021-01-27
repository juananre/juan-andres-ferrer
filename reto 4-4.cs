using System;

namespace reto_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // datos 

            Console.Write("ingresa w:");
            double w = double.Parse(Console.ReadLine());
            Console.Write("ingrese t:");
            double t = double.Parse(Console.ReadLine());
            Console.Write("ingrese angulo c:");
            double c = double.Parse(Console.ReadLine());

            //calculo de datos 

            double rc = c * Math.PI / 180;

            double y = Math.Cos(rc) * t;
            double z = Math.Sin(rc) * t;

            double xy = Math.Sqrt(((w * w)-(z * z)));

            double x = xy - y;

            //salida 

            Console.WriteLine("el lado x es: " + x);
            Console.WriteLine("y es: " + y);
            Console.WriteLine("z es: " + z);
            Console.WriteLine("la hipo es: " + xy);

            //https://youtu.be/0L7mRv4XCy8
        }
    }
}
