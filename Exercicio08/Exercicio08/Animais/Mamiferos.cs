using Exercicio08.Interface;

namespace Exercicio08.Animais
{
    public class Mamiferos:Animal,IAnimal
    {
        public Mamiferos(string type, string color, string skin):base(type, color, skin)
        {

        }
        // public override void Movimento()
        // {
        //     System.Console.WriteLine($"{this.Type}: Está Andando");

        // }

        public override void Som()
        {
            System.Console.WriteLine($"{this.Type}: Está Rosnando");
        }
    }
}