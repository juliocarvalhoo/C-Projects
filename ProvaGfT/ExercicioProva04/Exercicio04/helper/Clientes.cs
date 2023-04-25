namespace Exercicio04.helper
{
    public class Clientes
    {
        public string? Name { get; set; }
        public double Gasto { get; set; }
        public int Idade { get; set; }

        public Clientes(string name, double gasto, int idade)
        {
            this.Name = name;
            this.Gasto = gasto;
            this.Idade = idade;
        }

    }
}