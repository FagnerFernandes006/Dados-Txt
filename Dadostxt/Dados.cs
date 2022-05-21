﻿using System;
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
            sw.WriteLine(nome + ", " + email + ", " + rg);
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
    }
}