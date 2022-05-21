using System.Globalization;
using System;
namespace Dadostxt
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados dados = new Dados();

            Console.WriteLine("Entre com os Dados:");
            Console.Write("Nome do arquivo: ");
            dados.arquivo = Console.ReadLine();
            Console.Write("Nome: ");
            dados.nome = Console.ReadLine();
            Console.Write("Email: ");
            dados.email = Console.ReadLine();
            Console.Write("RG: ");
            dados.rg = Console.ReadLine();

            if (!File.Exists(@"C:\Temp\"))
            {
                dados.CriaPasta(@"C:\Temp\");
            }
            string path = @"C:\Temp\" + dados.arquivo + ".txt";

            if (!File.Exists(path))
            {
                dados.CriaFile(path);
                Console.WriteLine("Arquivo Criado com sucesso!");
                Console.WriteLine("Seu Arquivo esta salvo em: "+ path);
            }
            else if (File.Exists(path))
            {
                Console.Write("Já existe um aquivo com esse nome, deseja substituir? s/n ");
                char ch = char.Parse(Console.ReadLine());
                while (ch != 's' && ch != 'n')
                {
                    Console.WriteLine("Caracter não identificado!");
                    Console.WriteLine("Digite novamente");
                    Console.Write("Já existe um aquivo com esse nome, deseja substituir? s/n ");
                    ch = char.Parse(Console.ReadLine());
                }
                if (ch == 's')
                {
                    dados.SubstituiFile(path);
                    Console.WriteLine("Aquivo substtuido com sucesso!");
                    Console.WriteLine("Seu Arquivo esta salvo em: " + path);
                }
                else if (ch == 'n')
                {
                    Console.WriteLine("Aquivo permanece o mesmo.");
                }
            }
        }
    }
}