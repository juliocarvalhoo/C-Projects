using static System.Console;
using Exercicio04.helper;

namespace Exercicio04.helper
{
    public class Program
    {
        static void Main()
        {
            Clientes joao = new Clientes("João",11.001,39);
            Clientes ricardo = new Clientes("Ricardo",15.000,25);
            Clientes maria = new Clientes("Maria",19.000,14);

            WriteLine($"Nome do cliente...:{joao.Name}");
            WriteLine($"Gasto.............:{joao.Gasto}");
            WriteLine($"idade do cliente..:{joao.Idade}");

            double soma = joao.Gasto + ricardo.Gasto + maria.Gasto;
            WriteLine($"Valor Arrecadado:{soma}");

        }

    }
    
}
