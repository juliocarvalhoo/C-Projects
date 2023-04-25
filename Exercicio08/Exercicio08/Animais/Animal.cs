using Exercicio08.Interface;

namespace Exercicio08.Animais
{
    public class Animal:IAnimal      //SEALEAD, NAO DEIXA HERDAR //PRIVATE
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public string Skin { get; set; }

        public Animal(string type, string color, string skin)
        {
            this.Type = type;
            this.Color = color;
            this.Skin = skin;          
        }
        public virtual void Movimento()
        {

        }

        public virtual void Som()
        {
            
        }


    }
}