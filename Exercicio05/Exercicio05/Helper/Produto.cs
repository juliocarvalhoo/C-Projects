using static System.Console;
namespace Exercicio05.Helper
{
    public class Produto
    {
        public string? ProdutoName {get ; set;}
        public string? Marca {get ; set;}
        public int Codigo {get; set;}
        public double Valor {get; set;}
        
        public Produto(string produtoname, string marca, int codigo, double valor)
        {
            this.ProdutoName = produtoname;
            this.Marca = marca;
            this.Codigo = codigo;
            this.Valor = valor;
        }

        public static void ChamarProduto(List<Produto> chamarlista)
        {
            foreach(Produto item in chamarlista)
            {
                 string linha = new string('-',60);
                WriteLine($"Produto....: {item.ProdutoName}");
                WriteLine($"Marca......: {item.Marca}");
                WriteLine($"Codigo.....: {item.Codigo}");
                WriteLine($"Preço......: {item.Valor.ToString("0.00")}");
                WriteLine(linha);
            }

           
        }
    }
}


// id marca valor 