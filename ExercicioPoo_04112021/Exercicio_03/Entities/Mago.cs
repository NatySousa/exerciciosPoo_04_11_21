using System;
using System.Collections.Generic;

namespace Exercicio_03.Entities
{
    public class Mago : Personagem
    {
        public List<string> Magias { get; set; }

        public Mago()
        {
            Vida = 1000;
            Magias = new List<string>();
        }

        public override void LvlUp () 
        {
            Mana += 2;
            Inteligencia += 2;
            Vida++;
            Forca++;
            Level++;
            Console.WriteLine($"Mana........ : {Mana}");
            Console.WriteLine($"Inteligencia : {Inteligencia}");
            Console.WriteLine($"Vida........ : {Vida}");
            Console.WriteLine($"Forca....... : {Forca}");
            Console.WriteLine($"Level....... : {Level}");

        }

         public void Attack() 
        {
          var random  = new Random();
          var dano = (Inteligencia*Level) + random.Next(300) ;
          Console.WriteLine($"Força do ataque -- {dano}");
        }

        public void AprenderMagia(string magia)
        {
            
            Magias.Add(magia);
        }
        
    }
}