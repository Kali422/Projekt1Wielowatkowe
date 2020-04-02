using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Projekt1Wielowątkowe
{
    class Wersja2
    {
        double wynik;
        object zamek;

        public Wersja2()
        {
            this.wynik = 0;
            this.zamek = new object();
        }

        public double oblicz(int liczbaWatkow)
        {
            Thread[] threads = new Thread[liczbaWatkow];
            double xp = 1;
            double xk = 40;
            double dx = 0.00001;
            double przedzial = (xk - xp) / liczbaWatkow;
            int j = 0;
            for (int i = 0; i < liczbaWatkow; i++)
            {
                threads[i] = new Thread(() => sumaPrzedzialu(xp + j * przedzial, xp + (j++ + 1) * przedzial, dx));
            }

            foreach (Thread thread in threads)
            {
                thread.Start();
            }
            foreach (Thread thread in threads)
            {
                thread.Join();
            }
            return this.wynik * dx;
        }

        void sumaPrzedzialu(double xp, double xk, double dx)
        {
            double i = xp;
            while (i < xk)
            {
                double y = Funkcja.oblicz(i);
                lock(zamek)
                {
                    this.wynik += y;
                }
                i += dx;
            }
        }
    }

}
