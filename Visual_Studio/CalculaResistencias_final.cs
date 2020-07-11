using System;
using System.Text;
using System.Transactions;

namespace CalculaResistencias
{
    class Program
    {
        static void Main(string[] args)
        {
            short b1, b2, b3;
            double resultado, tb, ta;
            string cont;
            do
            {
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
                Console.WriteLine("10 Dorado");
                Console.WriteLine("11 Plateado");

                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("Dame Banda 1");
                    b1 = Convert.ToInt16(Console.ReadLine());

                } while ((b1 == 0) | (b1 > 9));

                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("Dame Banda 2");
                    b2 = Convert.ToInt16(Console.ReadLine());

                } while (b2 > 9);

                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("Dame Banda 3");
                    b3 = Convert.ToInt16(Console.ReadLine());
                } while ((b3 > 6 & b3 < 10) | b3 > 11);

                Console.WriteLine("");
                Console.WriteLine("Elegiste una resistencia con el siguiente codigo de colores:");
                Console.WriteLine("{0}, {1}, {2}", colore(b1), colore(b2), colore(b3));

                resultado = resistencia(b1, b2, b3);
                Console.WriteLine("");
                Console.WriteLine("El valor de la resistencia es: {0} Ohms con una tolerancia del {1}20%", resultado, Convert.ToChar(177));
                ta = resultado * 1.2;
                tb = resultado * 0.8;
                Console.WriteLine("valor de reciestecncia real ente los valores de {0} y {1}", tb, ta);
                Console.WriteLine("continualr si/no");
                cont = Console.ReadLine();

            } while (cont != "no");

            Console.ReadKey();
        }

        static double resistencia(short b1, short b2, short b3)
        {
            double x = 0, p;

            b1 *= 10; // b1= b1*10;
            x = b1 + b2;
            if (b3 > 0 & b3 < 6)
            {
                //p = Math.Pow(10,(b3));
                //x *= p;
                x *= Math.Pow(10,b3);

            }
            else if (b3 == 10){
                x *= 0.1;
            }else {
                x *= 0.01;
            }
            return (x);
        }

        static string colore(short color)
        {
            string r = "c";
            switch (color)
            {
                case 0:
                    r = "Negro";
                    break;
                case 1:
                    r = "Cafe";
                    break;
                case 2:
                    r = "Rojo";
                    break;
                case 3:
                    r = "Naranja";
                    break;
                case 4:
                    r = "Amarillo";
                    break;
                case 5:
                    r = "Verde";
                    break;
                case 6:
                    r = "Azul";
                    break;
                case 7:
                    r = "Morado/Violeta";
                    break;
                case 8:
                    r = "Gris";
                    break;
                case 9:
                    r = "Blanco";
                    break;
                case 10:
                    r = "Dorado";
                    break;
                case 11:
                    r = "Plateado";
                    break;
                default:
                    break;
            }
            return (r);
        }
    }
}
