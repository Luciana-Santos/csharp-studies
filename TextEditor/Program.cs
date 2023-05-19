using static System.Console;

namespace TextEditor
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
            WriteLine("O que você deseja fazer?");
            WriteLine("1 - Abrir arquivo");
            WriteLine("2 - Criar arquivo");
            WriteLine("0 - Sair");
            short option = short.Parse(ReadLine());

            switch (option)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    Open();
                    break;
                case 2:
                    Edit();
                    break;

                default:
                    Menu();
                    break;
            }
        }

        static void Open() { }

        static void Edit()
        {
            Clear();
            WriteLine("Digite seu texto abaixo (ESC para sair)");
            WriteLine("-----------------------");
        }
    }
}
