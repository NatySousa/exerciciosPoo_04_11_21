namespace Exercicio_07.Entities
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public virtual double Bonificacao()
        {
            return 0;
        } 


        
    }
}