using static System.Console;
using Exercicio05.Helper;


namespace Exercicio05
{
    public class Programa
    {
        static void Main()
        {
            Produto p1 = new Produto("Mouse","Logitec",98454521,999.999);
            
        
            List<Produto> listClasse = new List<Produto>{};
            listClasse.Add(new Produto("Teclado","Razer",45487874,1000));
            listClasse.Add(p1);

            Produto.ChamarProduto(listClasse);
        }
    }
}
