using System;
namespace Calculadora
{
    class Program
    {
        static void Main()
        {
            Menu();


        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("o que deseja fazer: ");
            Console.WriteLine("1 - soma");
            Console.WriteLine("2 - subtracao");
            Console.WriteLine("3 - divisao");
            Console.WriteLine("4 - multiplicação");
            Console.WriteLine("5 - sair");

            Console.WriteLine("---------------");
            Console.WriteLine("selecione uma opcao: ");

            int res = int.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }



        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"o resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();

        }

        static void Subtracao()
        {

            Console.Clear();

            Console.WriteLine("primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"o resultado da subtracao é {resultado}");
            Console.ReadKey();
            Menu();

        }

        static void Divisao()
        {

            Console.Clear();
            Console.WriteLine("primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"o resultado da divisao é: {resultado}");
            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("primeiro valor :");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("segundo valor :");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"o resultado da multiplicacao é {resultado}");
            Console.ReadKey();
            Menu();

        }




    }
}