using System;
using Microsoft.VisualBasic;
namespace desafioswitch
{
    class Program
    {
        static int xp;
        static String nível;

        static String nome;


        static void Main(string[]args)
        {

         classificação();
         condições();
         Console.WriteLine($"O Herói de nome {nome} está no nível {nível}");

        }

        static void classificação()
        {
            Console.Clear();
            Console.WriteLine("Qual o nome do herói?");
            Console.WriteLine("---------------");
            string nome = Console.ReadLine();
            Console.WriteLine("---------------");
            Console.WriteLine("");
            Console.WriteLine("Qual o xp");
            Console.WriteLine("---------------");
            xp = int.Parse(Console.ReadLine());
        }

        static void condições()
        {
            switch(xp)
            {
                case <= 1000:
                nível = "ferro";
                break;

                case <= 2000:
                nível = "Bronze";
                break;

                case <= 3000:
                nível = "Prata";
                break;

                case <= 4000:
                nível = "Ouro";
                break;
                
                case <= 5000:
                nível = "Platina";
                break;

                case <= 6000:
                nível = "Ascendente";
                break;

                case <= 7000:
                nível = "Imortal";
                break;

                case <= 8000:
                nível = "Ascendente";
                break;

                case <= 9000:
                nível = "Imortal";
                break;

                case <= 10000:
                nível = "Radiante"; 
                break;

            }
        }
    }
}