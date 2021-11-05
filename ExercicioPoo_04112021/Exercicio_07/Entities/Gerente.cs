namespace Exercicio_07.Entities
{
    public class Gerente : Funcionario
    {
        public override double Bonificacao() //para reescrever o método
        {
            return Salario + 10000;
        }
    }
}