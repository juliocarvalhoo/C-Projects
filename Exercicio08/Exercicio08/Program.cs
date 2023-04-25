using static System.Console;
using Exercicio08.Animais;

namespace Exercicio08
{
    public class Program
    {
        static void Main()
        {

            List<Animal> listaAnimais = new List<Animal>();

            Aves Juno = new Aves("Calopsita","Verde", "Penas");
            Repteis Salamandra = new Repteis("Lagarto","Branco","Escamas");
            Peixes Nemo = new Peixes("Peixe-Palhaço","Laranja","Escamas");

            listaAnimais.Add(Juno);
            listaAnimais.Add(Salamandra);
            listaAnimais.Add(Nemo);
           
            static void InfoAnimals(Animal objeto)
            {
                string linha = new string('-',60);
                WriteLine($"Tipo...............: {objeto.Type}");
                WriteLine($"Cor................: {objeto.Color}");
                WriteLine($"Pelugem............: {objeto.Skin}");
                objeto.Som(); 
                objeto.Movimento();       
                WriteLine(linha);
            }

            foreach (Animal item in listaAnimais)
            {
                InfoAnimals(item);
            }
            

        }
    }
    
}
