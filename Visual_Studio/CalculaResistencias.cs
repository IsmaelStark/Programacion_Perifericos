using System;

namespace CalculaResistencias
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1, b2, b3, resuktado,tb,ta;
            int error = 0;
            Console.WriteLine("Programa que calcula el valor de una resistencia de 3 bandas");
            Console.WriteLine("escribe el numero de acuerdo al color de las bandas");
            Console.WriteLine("0 Negro");
            Console.WriteLine("1 Cafe");
            Console.WriteLine("2 Rojo");
            Console.WriteLine("3 Naranja");
            Console.WriteLine("4 Amarillo");
            Console.WriteLine("5 Verde");
            Console.WriteLine("6 Azul");
            Console.WriteLine("7 Morado/Violeta");
            Console.WriteLine("8 Gris");
            Console.WriteLine("9 Blanco");


            do{
                Console.WriteLine("Dame Banda 1");
                b1 = Convert.ToInt16(Console.ReadLine());
                if (b1 == 0){
                    error = 1;
                }                else if ( b1 > 9)                {
                    error = 1;
                }else{
                    error = 0;
                }

            } while (error == 1);
            Console.WriteLine("Dame Banda 2");
            b2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Dame Banda 3");
            b3 = Convert.ToInt16(Console.ReadLine());
        }
    }
}
