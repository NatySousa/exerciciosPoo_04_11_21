using System;
using System.Collections.Generic;

namespace Exercicio_03.Entities
{
    public class Guerreiro : Personagem
    {
        public List<string> Habilidades { get; set; }

        public Guerreiro()
        {
            Vida = 1200;
            Habilidades = new List<string>();
        }
        public override void LvlUp () 
        {
            Mana++;
            Inteligencia++;
            Vida+= 2;
            Forca+= 2;
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
          var dano = (Forca*Level) + random.Next(300) ;
          Console.WriteLine($"Força do ataque -- {dano}");
        }

        
        public void AprenderHabilidade(string habilidade)
        {
            Habilidades.Add(habilidade);
        }
    }
}