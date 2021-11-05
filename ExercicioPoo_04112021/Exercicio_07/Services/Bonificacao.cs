using System;
using Exercicio_07.Entities;

namespace Exercicio_07.Services
{
    public class Bonificacao
    {
        public void ImprimiFuncionario()
        {
           var gerente = new Gerente();
           var supervisor = new Supervisor();
           var vendedor = new Vendedor();

            gerente.Nome = "Paula";
            gerente.Idade = 36;
            gerente.Salario = 7000;

            supervisor.Nome = "João";
            supervisor.Idade = 30;
            supervisor.Salario = 5000;

            vendedor.Nome = "Ana";
            vendedor.Idade =25;
            vendedor.Salario = 3000;

            Console.WriteLine("******Gerente******");
            Console.WriteLine($"Nome: {gerente.Nome}");
            Console.WriteLine($"Idade: {gerente.Idade}");
            Console.WriteLine($"Salario: {gerente.Salario}");
            Console.WriteLine($"Bonificação: {gerente.Bonificacao()}");
            Console.WriteLine();
            Console.WriteLine("******Supervisor******");
            Console.WriteLine($"Nome: {supervisor.Nome}");
            Console.WriteLine($"Idade: {supervisor.Idade}");
            Console.WriteLine($"Salario: {supervisor.Salario}");
            Console.WriteLine($"Bonificação: {supervisor.Bonificacao()}");
            Console.WriteLine();
            Console.WriteLine("******Vendedor******");
            Console.WriteLine($"Nome: {vendedor.Nome}");
            Console.WriteLine($"Idade: {vendedor.Idade}");
            Console.WriteLine($"Salario: {vendedor.Salario}");
            Console.WriteLine($"Bonificação: {vendedor.Bonificacao()}");
            
        }
        

    }
}