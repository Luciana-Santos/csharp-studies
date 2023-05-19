using static System.Console;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Clear();

            WriteLine("Selecione a operação que deseja fazer:");
            WriteLine("1 - Soma");
            WriteLine("2 - Subtração");
            WriteLine("3 - Divisão");
            WriteLine("4 - Multiplicação");
            WriteLine("5 - Sair");

            WriteLine("-------------------------");
            short res = short.Parse(ReadLine());

            switch (res)
            {
                case 1:
                    Add();
                    break;

                case 2:
                    Subtract();
                    break;

                case 3:
                    Divide();
                    break;

                case 4:
                    Multiply();
                    break;

                case 5:
                    System.Environment.Exit(0);
                    break;

                default:
                    Menu();
                    break;
            }
        }

        static void Add()
        {
            Clear();

            WriteLine("Primeiro valor:");
            float valueOne = float.Parse(ReadLine());

            WriteLine("Segundo valor:");
            float valueTwo = float.Parse(ReadLine());

            float total = valueOne + valueTwo;

            WriteLine("");
            WriteLine($"A soma dos números é: {total}");
            ReadKey();
        }

        static void Subtract()
        {
            Clear();

            WriteLine("Primeiro valor:");
            float valueOne = float.Parse(ReadLine());

            WriteLine("Segundo valor:");
            float valueTwo = float.Parse(ReadLine());

            float total = valueOne - valueTwo;

            WriteLine("");
            WriteLine($"A subtração dos números é: {total}");
            ReadKey();
        }

        static void Divide()
        {
            Clear();

            WriteLine("Primeiro valor:");
            float valueOne = float.Parse(ReadLine());

            WriteLine("Segundo valor:");
            float valueTwo = float.Parse(ReadLine());

            float total = valueOne / valueTwo;

            WriteLine("");
            WriteLine($"A divisão dos números é: {total}");
            ReadKey();
        }

        static void Multiply()
        {
            Clear();

            WriteLine("Primeiro valor:");
            float valueOne = float.Parse(ReadLine());

            WriteLine("Segundo valor:");
            float valueTwo = float.Parse(ReadLine());

            float total = valueOne * valueTwo;

            WriteLine("");
            WriteLine($"A multiplicação dos números é: {total}");
            ReadKey();
        }
    }
}
