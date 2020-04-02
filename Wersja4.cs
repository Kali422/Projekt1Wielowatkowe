using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Projekt1Wielowątkowe
{
    class Wersja4
    {
        double wynik;
        object zamek;

        public Wersja4()
        {
            this.wynik = 0;
            this.zamek = new object();
        }

        public double oblicz(int liczbaTaskow)
        {
            Task[] tasks = new Task[liczbaTaskow];
            double xp = 1;
            double xk = 40;
            double dx = 0.00001;
            double przedzial = (xk - xp) / liczbaTaskow;
            int j = 0;
            for (int i = 0; i < liczbaTaskow; i++)
            {
                tasks[i] = new Task(() => sumaPrzedzialu(xp + j * przedzial, xp + (j++ + 1) * przedzial, dx));
            }

            foreach (Task task in tasks)
            {
                task.Start();
            }
            foreach (Task task in tasks)
            {
                task.Wait();
            }
            return this.wynik * dx;
        }

        void sumaPrzedzialu(double xp, double xk, double dx)
        {
            double sumaLokalna = 0;
            double i = xp;
            while (i < xk)
            {
                double y = Funkcja.oblicz(i);

                sumaLokalna += y;

                i += dx;
            }

            lock (zamek)
            {
                wynik += sumaLokalna;
            }
        }
    }

}

