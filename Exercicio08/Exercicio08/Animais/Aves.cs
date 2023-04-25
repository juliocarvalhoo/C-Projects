namespace Exercicio08.Animais
{
    public class Aves:Animal
    {
        public Aves(string type, string color, string skin):base(type, color, skin)
        {

        }
        public override void Movimento()
        {
            System.Console.WriteLine($"{this.Type}: Está Voando");
        }

        public override void Som()
        {
            System.Console.WriteLine($"{this.Type}: Está Cantarolando");
        }
    }
}