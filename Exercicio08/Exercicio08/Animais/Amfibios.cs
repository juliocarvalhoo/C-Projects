namespace Exercicio08.Animais
{
    public class Amfibios:Animal 
    {
        public Amfibios(string type, string color, string skin):base(type, color, skin)
        {

        }
        public override void Movimento()
        {
            System.Console.WriteLine($"{this.Type}: Está Pulando");
        }

        public override void Som()
        {
            System.Console.WriteLine($"{this.Type}: Está a Coaxar");
        }

    }
}