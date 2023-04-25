using static System.Console;
namespace Exercicio07.Persona
{
    public class Person
    {
        public string Name { get; set; }
        public string Genero { get; set; }
        public int Idade { get; set; }
        
        public Person(string name, string genero, int idade)
        {
            this.Name = name;
            this.Genero = genero;
            this.Idade = idade;   
        }
        
        public static void ChamarInformacao(Person chamarlista)
        {
            int expectativaVida = 0;
            if (chamarlista.Genero== "M")
            {
                expectativaVida= 80 - chamarlista.Idade; 
            }
            else
            {
                expectativaVida= 90 - chamarlista.Idade; 
            }

            string linha = new string('-',60);
            WriteLine($"Nome...............: {chamarlista.Name}");
            WriteLine($"Genero.............: {chamarlista.Genero}");
            WriteLine($"Idade..............: {chamarlista.Idade}");
            WriteLine($"Extactativa vida + : {expectativaVida}");
            WriteLine(linha);
        }

    }          
}