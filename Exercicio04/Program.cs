using static System.Console;
using Exercicio04.Funcionarios;     //MSM PASTA NAO PRECISA USAR O USING

namespace Exercicio04
{
    public class Main
    {
        public void Inicio()
        {
            Funcionario f1 = new Funcionario("Júlio", 22, 1250.50);
            f1.Bonus();

        }
    }
}
