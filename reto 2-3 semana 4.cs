using System;

namespace reto_2_3_semana_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ramdom = new Random();
            int dados1 = 0;
            int dados2 = 0;
            int totalNumerico = 0;
            string SINO = "s";
            int turnos = 0;
            int turnos6 = 0;
            double porcentaje = 0;


            while (SINO =="s")
            {
                dados1 = ramdom.Next(1, 7);
                totalNumerico += dados1;
                
                Console.WriteLine("ha sacado el dado: " + dados1);

                dados2 = ramdom.Next(1, 7);
                totalNumerico += dados2;
                Console.WriteLine("ha sacado el dado: " + dados2);
                turnos ++; 
                Console.WriteLine("la suma de todas los dados: " + totalNumerico);
                if (dados2 + dados1 >= 6)
                {
                    turnos6 ++; 
                }

                if (totalNumerico >= 100)
                {
                    SINO = "n";
                    Console.WriteLine("has ganado");
                    porcentaje = (double)turnos6 * 100 / turnos;
                    Console.WriteLine("el porcentaje de veces que saco 6 o mas fue de: " + porcentaje + "%");
                }

                if (dados1 + dados2 == 2)
                {
                    Console.WriteLine("has perdio");
                    SINO = "n";
                }
   

                if (SINO == "s")
                {
                    Console.WriteLine("¿desea tirar otra? s/n ");
                    SINO = Console.ReadLine();
                    if(SINO != "s")
                    {
                        Console.WriteLine("te falto estos putos " + (100 - totalNumerico));
                        porcentaje = (double)turnos6 * 100 / turnos;
                        Console.WriteLine("el porcentaje de veces que saco 6 o mas fue de: " + porcentaje + "%");
                    }


                }

                else if(SINO != "s")
                {
                    if (totalNumerico < 100)
                    {

                        if (SINO != "s")
                        {
                            Console.WriteLine("perdiste y te falto estos putos " + (100 - totalNumerico));
                            porcentaje = (double)turnos6 * 100 / turnos;
                            Console.WriteLine("el porcentaje de veces que saco 6 o mas fue de: " + porcentaje + "%");
                        }

                    }
                }



                //https://youtu.be/KdoHcv88DYI

            }
        }
    }
}
