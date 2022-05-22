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
            string path = @"C:\Temp\" + dados.arquivo + ".txt";

            dados.CriarArquivo(path);
            Console.WriteLine("-----------------");
            dados.exibetxt(path);
        }
    }
}
