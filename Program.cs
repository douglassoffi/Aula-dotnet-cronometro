using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }

        // Funcao Menu seleciona unidade de media e duracao do cronometro
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine(
                "S - Segundos\n" +
                "M - Minutos\n" +
                "0 - Sair\n" +
                "Quanto tempo deseja contar?");

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            string data = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            if (data == "0")
                return;

            if (!Regex.IsMatch(data, @"^[1-9]\d*[sm]$"))
            {
                Console.Clear();
                Console.WriteLine("Formato inválido. Use número seguido de S ou M.");
                Thread.Sleep(3000);
                Menu();
                return;
            }

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...\n");
            Thread.Sleep(1000);
            Console.WriteLine("Set...\n");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(1000);
            Start(time);
        }
        // Funcao Start inicia cronometro e para no momento selecionado previamente em Menu
        static void Start(int time)
        {
            float currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado!");
            Thread.Sleep(2000);
            Menu();
        }
    }
}

