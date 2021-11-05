using System;
using Exercicio_03.Entities;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var mago = new Mago();
            Console.WriteLine("Infome o nome do personagem: ");
            mago.Nome = Console.ReadLine();
            mago.AprenderMagia("Wingsrdium Leviosa");
            mago.LvlUp();

            foreach (var item in mago.Magias)
            {
                Console.WriteLine(item);
            }

            mago.Attack();

            var guer = new Guerreiro();
            guer.AprenderHabilidade("Giro da Morte");
            guer.LvlUp();

            foreach (var item in guer.Habilidades)
            {
                Console.WriteLine(item);
            }

            guer.Attack();
        }
    }
}
