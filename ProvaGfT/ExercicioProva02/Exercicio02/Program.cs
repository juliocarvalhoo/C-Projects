using static System.Console;
using Exercicio02.Aluno;

namespace Exercicio02
{
    public class Program
    {
        static void Main()
        {
            List<Formato> listAlunos = new List<Formato>();
            List<double> notasGerais = new List<double>();

            // Formato julio = new Formato(22109, 15, 8, 7, 8);
            // Formato thiago= new Formato(22111, 30, 8, 7, 8);
            // Formato alexandre = new Formato(22101, 12, 5, 4, 2);

            // listAlunos.Add(julio);
            // listAlunos.Add(thiago);
            // listAlunos.Add(alexandre);

            int imatricula = 0;
            int ifaltas = 0;
            double n1 = 0;
            double n2 = 0;
            double n3 = 0;

            for (int i = 0; i < 3; i++)
            {
                WriteLine("Insira a matricula: ");
                imatricula = int.Parse(ReadLine());

                WriteLine("Insira a faltas: ");
                ifaltas = int.Parse(ReadLine());

                WriteLine("Insira a nota 1: ");
                n1 = double.Parse(ReadLine());

                WriteLine("Insira a nota 2: ");
                n2 = double.Parse(ReadLine());

                WriteLine("Insira a nota 3: ");
                n3 = double.Parse(ReadLine());

                Formato j = new Formato(imatricula, ifaltas, n1, n2, n3);
                listAlunos.Add(j);

                notasGerais.Add(n1);
                notasGerais.Add(n2);
                notasGerais.Add(n3);

            }

            foreach (var item in listAlunos)
            {
                item.ChamarInformacoes();               
            }

            WriteLine($"Maior nota...........: {notasGerais.Max()}");
            WriteLine($"Menor nota...........: {notasGerais.Min()}");
            
            
            Formato ilha = new Formato();
            ilha.ChamarReprovados();
            
        

        }
    }
}


