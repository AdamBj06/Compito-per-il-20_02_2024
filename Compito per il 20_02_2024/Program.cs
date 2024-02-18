using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vettori;

namespace Compito_per_il_20_02_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrato piano = new Quadrato(400 * Math.Pow(10, 6));

            Corpo m1 = new Corpo(6 * Math.Pow(10, 24), 0, 0);
            Corpo m2 = new Corpo(7 * Math.Pow(10, 22), piano.Lato, 0);
            Corpo m3 = new Corpo(m2.Massa, piano.Lato, piano.Lato);
            Corpo m4 = new Corpo(m2.Massa, 0, piano.Lato);

            Vettore gravità = new Vettore(0, -9.81d);//vettore accelerazione di gravità
            Vettore peso1 = m1.Massa * gravità;//vettore forza peso
            Vettore normale1 = -peso1;//vettore forza vincolante del tavolo

            Vettore forza = peso1 + normale1;//vettore forza risultante

            Console.ReadKey();
        }

        public class Quadrato
        {
            public double Lato { get; set; }
            public Quadrato(double l)
            {
                Lato = l;
            }
        }

        public class Corpo
        {
            public double Massa { get; set; }
            public double PosX { get; set; }
            public double PosY { get; set; }
            public Corpo(double m, double x, double y)
            {
                Massa = m;
                PosX = x;
                PosY = y;
            }
        }
    }
}
