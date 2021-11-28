using System;
using static System.Console;

namespace Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = "Aula de programação";
            string p = "de";
            WriteLine($" A frase '{f}' contem '{p}' ? ");
            WriteLine($"--------------------------------------------");

            if(f.Contains("de") == true)
            {
                WriteLine($"Sim, a frase contem '{p}'");
            }

            else
            {
                WriteLine($"Não, a frase não contem '{p}'");
            }
        }
    }
}
