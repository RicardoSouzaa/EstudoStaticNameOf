using System;
using static System.Console;
using System.Collections.Generic;
using System.Globalization;

namespace TesteGeral
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                string produto = "peixe";

                DateTime lancto = new DateTime(2010, 5, 15);

                WriteLine($"o {produto} tem {idade(lancto.Year)} anos");
                WriteLine($"o {produto} tem {idade(2023)} anos");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

            ReadLine();
        }

        public static int idade(int pAno)
        {
            if (pAno > DateTime.Today.Year)
            {
                throw new Exception($"ano inválido: parametro {nameof(pAno)}");
            }
            return DateTime.Today.Year - pAno;
        }
    }
}