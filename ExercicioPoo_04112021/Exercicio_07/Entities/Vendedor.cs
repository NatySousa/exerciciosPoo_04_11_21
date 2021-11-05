namespace Exercicio_07.Entities
{
    public class Vendedor : Funcionario

    {
        
        public override double Bonificacao() //para reescrever o método
        {
            return Salario + 3000;
        }
    }
}