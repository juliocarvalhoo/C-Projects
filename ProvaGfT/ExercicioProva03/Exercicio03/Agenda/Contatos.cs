using static System.Console;
namespace Exercicio03.Agenda
{
    public class Contatos
    {
        public string? Nome { get; set; }
        public long Numero { get; set; } 
        public int Idade { get; set; }
        public List<Contatos> listaContatos2 = new List<Contatos>();
        public Contatos(string nome, long numero, int idade)
        {
            this.Nome=nome;
            this.Numero=numero;
            this.Idade=idade;            
        }     
        
        void InserirContato2()
        {
            string linha = new string('-',70);
            WriteLine("Insira o nome por favor: ");
            string? iNome = ReadLine();
            WriteLine("Insira o Número celular: ");
            long iNumero = long.Parse(ReadLine());
            WriteLine("Insira o sua idade: ");
            int iIdade = int.Parse(ReadLine());
            listaContatos2.Add(new Contatos(iNome,iNumero,iIdade));
            listaContatos2 = listaContatos2.OrderBy(x => x.Nome).ToList();

            public void Perguntas()
        {
            WriteLine("Insira o novo nome por favor: ");
            string? eNome = ReadLine();
            WriteLine("Insira o novo Número celular: ");
            long eNumero = long.Parse(ReadLine()??string.Empty);
            WriteLine("Insira sua nova sua idade: ");
            int eIdade = int.Parse(ReadLine()??string.Empty);
        }
        }  

        
    }
}