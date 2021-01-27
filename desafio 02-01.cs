using System;

namespace clase_de_programacion
{
    public class Program
    {
        public static void Main(string[] args)
        {
			// Entrada del usuario de la variable X1
			Console.Write("Ingrese Z: ");
			double x1 = double.Parse(Console.ReadLine());

			// Entrada del usuario de la variable Y1
			Console.Write("Ingrese Y: ");
			double y1 = double.Parse(Console.ReadLine());

			//hipotenusa
			
			double hiptenusa = Math.Sqrt((x1 * x1) + (y1 * y1));

			//angulo a 
			double a = Math.Asin(y1 / hiptenusa);
			double aG = a * 180 / Math.PI;
			//angulo c
			double c = Math.Asin(x1 / hiptenusa);
			double cG = c * 180 / Math.PI;

			//slida 
			Console.WriteLine("hipotenusa es:" + hiptenusa);

			Console.WriteLine("angulo a es:" + aG);

			Console.WriteLine("angulo c es:" + cG);

			//https://www.youtube.com/video/Mk8mAZAukkI/edit
		}
	}
}
