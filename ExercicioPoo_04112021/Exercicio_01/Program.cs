using System;
using Exercicio_01.Entities;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var veiculo = new Veiculo();
            System.Console.WriteLine(  veiculo.IsLigado );     
            veiculo.Acelerar();
            veiculo.Ligar();
            veiculo.Acelerar();
            veiculo.Abastecer(30);
            veiculo.Frear();
            veiculo.Pintar("Azul");
            veiculo.Desligar();


        }
    }
}
