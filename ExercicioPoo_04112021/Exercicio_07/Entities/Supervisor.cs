namespace Exercicio_07.Entities
{
    public class Supervisor : Funcionario
    {
        
        public override double Bonificacao() //para reescrever o método
        {
            return Salario + 5000;
        }
    }
}