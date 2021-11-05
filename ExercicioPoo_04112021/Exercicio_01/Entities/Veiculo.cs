namespace Exercicio_01.Entities
{
    public class Veiculo
    {
        public string  Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public float Km { get; set; }
        public bool IsLigado { get; set; }
        
        public int LitrosCombustivel { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; set; }

        public void Acelerar() 
        {
            if (IsLigado)
            {
                Velocidade +=20;
            }
            else
            {
                    System.Console.WriteLine("Aviso: Não é possível acelerar, veículo desligado.");
            }
           
        }

         public void Abastecer(int combustivel) 
        {
            if (LitrosCombustivel == 60)
            {
                System.Console.WriteLine("Aviso: Não é possível abastecer, tanque cheio.");
            }
            else if ((LitrosCombustivel + combustivel) > 60)
            {
                var excesso = ((LitrosCombustivel + combustivel) - 60);

                 System.Console.WriteLine("Aviso: Não é possível abastecer, pois irá exceder a capacidade do tanque em ." + excesso );
            } 
            else
            {
                LitrosCombustivel += combustivel;
            }


        } 

         public void Frear() 
        {
            if (IsLigado && Velocidade > 0)
            {
                Velocidade -=20;
            }
            else
            {
                System.Console.WriteLine("Aviso: Não é possível frear, veículo parado ou desligado.");
            }
        }  

         public void Pintar(string cor) 
        {
            Cor = cor;
        System.Console.WriteLine(  "Cor atual do veículo " + Cor);
        }  

         public void Ligar() 
        {
            if (!IsLigado)
            {
                IsLigado = true;
                System.Console.WriteLine(  "Veículo ligado");
            }
        }  

         public void Desligar() 
        {
             if (IsLigado && Velocidade == 0)
            {
                IsLigado = false;
                System.Console.WriteLine(  "Veículo desligado");
            }

        }
       
    }
}