using System;

namespace Aula_13_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            int meses = (idade * 12);
            int dias = idade * 365;
            int horas = dias * 24;
            int minutos = horas * 60;

            System.Console.WriteLine("Idade em meses: "+meses);
            System.Console.WriteLine("Idade em dias: "+dias);
            System.Console.WriteLine("Idade em horas: "+horas);
            System.Console.WriteLine("Idade em minutos: "+minutos);


        }
    }
}
