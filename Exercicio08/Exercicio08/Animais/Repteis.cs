namespace Exercicio08.Animais
{
    public class Repteis:Animal
    {
        public Repteis(string type, string color, string skin):base(type, color, skin)
        {

        }
        public override void Movimento()
        {
            System.Console.WriteLine($"{this.Type}: Está Rastejando");
        }

        public override void Som()
        {
            System.Console.WriteLine($"{this.Type}: É Silencioso");
            
        }
    }
}