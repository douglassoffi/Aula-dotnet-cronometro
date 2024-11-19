using System.Runtime.Intrinsics.Arm;

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
            Console.WriteLine(
                "S - Segundos\n" +
                "M - Minutos\n" +
                "0 - Sair\n" +
                "Quanto tempo deseja contar?");
        }

        string data = Console.ReadLine().ToLower();

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

                Console.Clear();
                Console.WriteLine("Cronômetro finalizado!");
                Thread.Sleep(2500);
            }
        }
    }
}

