using System.Threading;
using static System.Console;

namespace Stopwatch
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Clear();
            WriteLine("S = Segundos => <<10s>> = 10 segundos");
            WriteLine("M = Minuto => <<1m>> = 1 minutos");
            WriteLine("0 = Sair");
            WriteLine("Quanto tempo deseja contar?");

            string data = ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            WriteLine(time);
            WriteLine(type);

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Clear();
            WriteLine("Ready...");
            Thread.Sleep(1000);
            WriteLine("Set...");
            Thread.Sleep(1000);
            WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Clear();
                currentTime++;
                WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Clear();
            WriteLine("Stopwatch finalizado.");
            Thread.Sleep(2500);
        }
    }
}
