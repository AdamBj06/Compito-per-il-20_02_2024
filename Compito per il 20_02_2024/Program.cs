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
            const double G = 6.673e-11;

            Corpo m1 = new Corpo(6e24, new Vettore(0, 0));
            Corpo m2 = new Corpo(7e22, new Vettore(400e6, 0));
            Corpo m3 = new Corpo(m2.Massa, new Vettore(400e6, 400e6));
            Corpo m4 = new Corpo(m2.Massa, new Vettore(0, 400e6));

            Vettore gravità2_1 = G * m1.Massa * m2.Massa / Vettore.Modulo(m2.Posizione) * (m2.Posizione / Vettore.Modulo(m2.Posizione));
            Vettore gravità3_1 = G * m1.Massa * m3.Massa / Vettore.Modulo(m3.Posizione) * (m3.Posizione / Vettore.Modulo(m3.Posizione));
            Vettore gravità4_1 = G * m1.Massa * m4.Massa / Vettore.Modulo(m4.Posizione) * (m4.Posizione / Vettore.Modulo(m4.Posizione));

            Console.ReadKey();
        }

        public class Corpo
        {
            public double Massa { get; set; }
            public Vettore Posizione { get; set; }
            public Corpo(double m, Vettore pos)
            {
                Massa = m;
                Posizione = pos;
            }
        }
    }
}
