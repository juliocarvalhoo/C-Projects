namespace Exercicio04.Funcionarios
{
    public class Funcionario
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
        public  double Salario {get; set;}

        public Funcionario(string nome, int idade, double salario)
        {
            this.Nome=nome;
            this.Idade = idade;
            this.Salario = salario;
        }
        public void Bonus()
        {
            
            Salario += Salario / 100.0 * 10;
            return Salario;
        }

                
    }
}