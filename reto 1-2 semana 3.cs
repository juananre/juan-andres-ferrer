using System;

namespace reto_1_2_semana_3__alternativa_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("ingrese su salario: ");
            int salario = int.Parse(Console.ReadLine());
            Console.Write("ingrese el tipo de contrato independiente(1) dependiente(2): ");
            int contrato = int.Parse(Console.ReadLine()); // 1 = Independiente | 2 = Dependiente

            double baseCotizacion = (salario * 40) / 100;
            double ARL = 0;
            double Smml = 877802;
            if (baseCotizacion < Smml)
            {
                baseCotizacion = Smml;
            }

            switch (contrato)
            {
                case 1:
                    {
                        Console.Write("ingrese el riesgo laboral: ");
                        int TasaDeRiesgo = int.Parse(Console.ReadLine());
                        switch (TasaDeRiesgo)
                        {
                            case 1: ARL = (baseCotizacion * 0.522) / 100; break;
                            case 2: ARL = (baseCotizacion * 1.044) / 100; break;
                            case 3: ARL = (baseCotizacion * 2.436) / 100; break;
                            case 4: ARL = (baseCotizacion * 4.350) / 100; break;
                            case 5: ARL = (baseCotizacion * 6.960) / 100; break;
                            default: Console.WriteLine("vuelva a ingresr los datos"); break;
                        }

                        double EPS = (baseCotizacion * 12.5) / 100;
                        double Pension = (baseCotizacion * 16) / 100;
                        double deudaciones = EPS + Pension + ARL;
                        double SalarioReal = salario - deudaciones;
                        double ingresoanual = SalarioReal * 12;

                        Console.WriteLine("su salario mensual es: " + SalarioReal);
                        Console.WriteLine("su salario anual es: " + ingresoanual);

                        break;
                    }
                case 2:
                    {
                        double EPS = (baseCotizacion * 4) / 100;
                        double Pension = (baseCotizacion * 4) / 100;
                        double deudaciones = EPS + Pension;
                        double SalarioReal = salario - deudaciones;
                        double ingresoanual = SalarioReal * 12 + salario;

                        Console.WriteLine("su salario mensual es: " + SalarioReal);
                        Console.WriteLine("su salario anual es: " + ingresoanual);
                        break;
                    }
                default: Console.Write("vuelva a ingresr los datos"); break;
            }
            //https://youtu.be/XlyDh37Kir8

            Console.ReadKey();
        }

    }
}
