using System;

namespace ejercicio_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ingrese t: ");
            double t = double.Parse(Console.ReadLine());

            Console.Write("angulo a: ");
            double ag = double.Parse(Console.ReadLine());

            //angulo c
            double cG = 180 - 90 - ag;
            //cambio
            double aR = ag * Math.PI / 180;

            // lado y 
            double y = t * Math.Sin(aR);
            //lado z
            double z = t * Math.Cos(aR);

            //salida 
            Console.WriteLine("angulo c: " + cG);
            Console.WriteLine("lado y: " + y);
            Console.WriteLine("lado z: " + z);

            //https://www.youtube.com/watch?v=Vjbw8gstwyQ
        }
    }
}
