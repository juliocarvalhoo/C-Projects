using static System.Console;
namespace Exercicio03.Biblioteca
{
    public class Biblioteca
    {
        public string? Livro {get; set;}
        public int NumeroPaginas {get; set;}
    }
    public void Biblioteca(string livro, int numeroPaginas)
    {
        this.Livro = livro;
        this.NumeroPaginas = numeroPaginas; 
    }
}