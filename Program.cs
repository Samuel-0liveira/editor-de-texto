using System;
using System.Runtime.CompilerServices;
using System.IO;

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
            Console.Clear();

            Console.WriteLine("O que deseja realizar?");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar um novo arquivo");
            Console.WriteLine("0 - Sair");
            short opcao = short.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    Abrir();
                    break;
                case 2:
                    NovoArquivo();
                    break;
                case 0:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void Abrir()
        {

        }

        static void NovoArquivo()
        {
            Console.Clear();

            Console.WriteLine("Digite o seu texto abaixo (esc para sair):");
            Console.WriteLine("----------------------------------------------");
            string texto = "";

            do 
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            } while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine(texto);
        }

        static void Salvar(string texto)
        {
            Console.Clear();

            Console.WriteLine("O arquivo deve ser salvo em qual caminho?");
            var caminho = Console.ReadLine();

            using(var arquivo = new StreamWriter(caminho!))
            {
                arquivo.Write(texto);
            }
        }
    }
}