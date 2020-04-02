using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Projekt1Wielowątkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int watki = 5;


            stopwatch.Start();
            Wersja1 wersja1 = new Wersja1();
            double wynik1 = wersja1.oblicz(watki);
            stopwatch.Stop();
            Console.WriteLine("Wersja 1 programu wykonała się w: " + stopwatch.Elapsed + " z wynikiem: " + wynik1);

            stopwatch.Restart();
            Wersja2 wersja2 = new Wersja2();
            double wynik2 = wersja2.oblicz(watki);
            stopwatch.Stop();
            Console.WriteLine("Wersja 2 programu wykonała się w: " + stopwatch.Elapsed + " z wynikiem: " + wynik2);

            stopwatch.Restart();
            Wersja3 wersja3 = new Wersja3();
            double wynik3 = wersja3.oblicz(watki);
            stopwatch.Stop();
            Console.WriteLine("Wersja 3 programu wykonała się w: " + stopwatch.Elapsed + " z wynikiem: " + wynik3);

            stopwatch.Restart();
            Wersja4 wersja4 = new Wersja4();
            double wynik4 = wersja4.oblicz(watki);
            stopwatch.Stop();
            Console.WriteLine("Wersja 4 programu wykonała się w: " + stopwatch.Elapsed + " z wynikiem: " + wynik4);
            Console.ReadKey();
        }
    }
}
