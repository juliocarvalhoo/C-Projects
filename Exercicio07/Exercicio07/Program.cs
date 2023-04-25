using static System.Console;
using Exercicio07.Persona;

namespace Exercicio07
{
    public class Pessoa
    {
        static void Main()
        {
           Person p1 = new Person("Júlio","M",26);
           Person p2 = new Person("Alexandra","F",28);
           Person p3 = new Person("Thiago","M",34);
           
            List<Person> listObjeto = new List<Person>();
            listObjeto.Add(p1);
            listObjeto.Add(p2);
            listObjeto.Add(p3);
           
           foreach (Person item in listObjeto)
           {
               Person.ChamarInformacao(item);               
           }
        }


    }    
}