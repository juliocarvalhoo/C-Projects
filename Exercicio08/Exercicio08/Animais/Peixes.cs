namespace Exercicio08.Animais
{
    public class Peixes:Animal
    {
        public Peixes(string type, string color, string skin):base(type, color, skin)
        {

        }
        public override void Movimento()
        {
            System.Console.WriteLine($"{this.Type}: Está Nadando");

        }

        public override void Som()
        {
            System.Console.WriteLine($"{this.Type}: Glub Glub");
        }
        
    }
}