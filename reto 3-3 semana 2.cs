using System;

namespace reto_3_3_semana_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Entrada de datos
            Console.Write("ingrese el tipo de contrato independiente(1) dependiente(2): ");
            int contrato = int.Parse(Console.ReadLine()); // 1 = Independiente | 2 = Dependiente
            Console.Write("ingrese su salario: ");
            int salario = int.Parse(Console.ReadLine());

            double baseCotizacion = (salario * 40) / 100;
            double ARL = 0;
            double Smml = 877802;
            if (baseCotizacion < Smml)
            {
                baseCotizacion = Smml;
            }
            // Entradas adicionales...
            
                if (contrato == 1)
                // Independiente
                {
                    Console.Write("ingrese el riesgo laboral: ");
                    int TasaDeRiesgo = int.Parse(Console.ReadLine());
                    if (TasaDeRiesgo == 1)
                    {
                         ARL = (baseCotizacion * 0.522) / 100;
                    }
                    else if (TasaDeRiesgo == 2)
                    {
                         ARL = (baseCotizacion * 1.044) / 100;
                    }
                    else if (TasaDeRiesgo == 3)
                    {
                         ARL = (baseCotizacion * 2.436) / 100;
                    }
                    else if (TasaDeRiesgo == 4)
                    {
                         ARL = (baseCotizacion * 4.350) / 100;
                    }
                    else if (TasaDeRiesgo == 5)
                    {
                         ARL = (baseCotizacion * 6.960) / 100;
                    }
                    

                    double EPS = (baseCotizacion * 12.5) / 100;
                    double Pension = (baseCotizacion * 16) / 100;
                    double deudaciones = EPS + Pension + ARL;
                    double SalarioReal = salario - deudaciones;
                    double ingresoanual = SalarioReal * 12;

                    Console.WriteLine("su salario mensual es: " + SalarioReal);
                    Console.WriteLine("su salario anual es: " + ingresoanual);
                }
            
            else if (contrato == 2)// Dependiente
            {
                double EPS = (baseCotizacion * 4 )/ 100;
                double Pension = (baseCotizacion * 4 )/ 100;
                double deudaciones = EPS + Pension;
                double SalarioReal = salario - deudaciones;
                double ingresoanual = SalarioReal * 12 + salario;

                Console.WriteLine("su salario mensual es: " + SalarioReal);
                Console.WriteLine("su salario anual es: " + ingresoanual);
            }

            //https://youtu.be/EL7wBBBQUlM
        }
    }
}
