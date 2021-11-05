using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio_04.Entities
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void MaisVelho(List<Pessoa> pessoas)
        {
            var nome = string.Empty; //empty "" (vazio)
            var idade = 0;

            Console.WriteLine($"A quantidade de pessoas nesta lista é de {pessoas.Count}") ;

            foreach(var item in pessoas.ToList())
            {                
                if(item.Idade > idade)
                {
                    nome = item.Nome;
                    idade = item.Idade;
                }
                if(item.Idade<18) 
                {
                    pessoas.Remove(item);
                } 
                if(item.Nome=="Jéssica")
                {
                   Console.WriteLine( $"Nome : {item.Nome}");
                   Console.WriteLine( $"Idade : {item.Idade}");
                }
            }

             Console.WriteLine($"A quantidade pessoas maior de 18 anos nesta lista é de {pessoas.Count}");

            Console.WriteLine($"A pessoa mais velha é {nome} com {idade} anos.");
        }

    }
}