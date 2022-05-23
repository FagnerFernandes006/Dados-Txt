using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dadostxt
{
    public class Dados
    {
        public string arquivo;
        public string email;
        public string nome;
        public string rg;

        public void CriaFile(string patch)
        {
            StreamWriter sw = new StreamWriter(patch);
            sw.WriteLine("Nome: " + nome);
            sw.WriteLine("Email: " + email);
            sw.WriteLine("RG: " + rg);
            sw.Close();
        }
        public void SubstituiFile(string patch)
        {
            File.Delete(patch);
            CriaFile(patch);
        }
        public void CriaPasta(string patch)
        {
            Directory.CreateDirectory(@"C:\Temp\");
        }
        public void exibetxt(string patch)
        {
            string[] linhas = File.ReadAllLines(patch);
            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
            }
        }
        public void CriarArquivo(string path)
        {
            if (!File.Exists(@"C:\Temp\"))
            {
                CriaPasta(@"C:\Temp\");
            }

            if (!File.Exists(path))
            {
                CriaFile(path);
                Console.WriteLine("Arquivo Criado com sucesso!");
                Console.WriteLine("Seu Arquivo esta salvo em: " + path);
            }
            else if (File.Exists(path))
            {
                Console.Write("Já existe um arquivo com esse nome, deseja substituir? s/n ");
                char ch = char.Parse(Console.ReadLine());
                while (ch != 's' && ch != 'n')
                {
                    Console.WriteLine("Caracter não identificado!");
                    Console.WriteLine("Digite novamente");
                    Console.Write("Já existe um arquivo com esse nome, deseja substituir? s/n ");
                    ch = char.Parse(Console.ReadLine());
                }
                if (ch == 's')
                {
                    SubstituiFile(path);
                    Console.WriteLine("Arquivo substituido com sucesso!");
                    Console.WriteLine("Seu Arquivo esta salvo em: " + path);
                }
                else if (ch == 'n')
                {
                    Console.WriteLine("Arquivo permanece o mesmo.");
                }
            }
        }
    }
}
