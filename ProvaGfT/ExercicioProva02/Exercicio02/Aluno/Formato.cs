using static System.Console;
namespace Exercicio02.Aluno
{
    public class Formato
    {
        public int Matricula { get; set; }
        public int Faltas { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public Formato(int matricula, int faltas, double nota1, double nota2, double nota3)
        {
            this.Matricula = matricula;
            this.Faltas = faltas;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
        }

        public Formato()
        {
            
        }
        public static int contadorreprovados = 0;
        public static int contador = 0;

        public void ChamarInformacoes()
        {
            string linha = new ('-',80);
            string testeFrequencia = "";
            string testeNota = "";
            string aprovacao = "";

            if(this.Faltas<=22) testeFrequencia = "Aluno Aprovado"; 
            else contador++;
            
            double notaFinal = (this.Nota1 + this.Nota2 + this.Nota3)/3.0;

            if (notaFinal>=5) testeNota= "Aluno Aprovado";
            else testeNota = "pra nao dar erro";

            if(testeFrequencia == testeNota) aprovacao =  "Aluno Aprovado"; 
            else 
            {
                aprovacao = "Aluno Reprovado";
                contadorreprovados+=1;
            }

            WriteLine($"Número da matrícula:...........: {this.Matricula}");
            WriteLine($"Média:.........................: {Math.Round(notaFinal,2)}");
            WriteLine($"Estado.........................: {aprovacao}");
            WriteLine(linha);

        }
        
        public void ChamarReprovados()
        {
            WriteLine($"Alunos Reprovados.............: {contadorreprovados}");
            WriteLine($"Alunos Reprovados frequencia..: {contador/3.0*100} %");
        }
    

    }
}