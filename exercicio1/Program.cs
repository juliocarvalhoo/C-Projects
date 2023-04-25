using static System.Console;

WriteLine("Insira um número qualquer: ");
string? numberString = "255";
List<char> lista = new List<char>();


foreach (char item in numberString)
{
    lista.Add(item);
}

var numberofhouses = lista.Count();
WriteLine(numberofhouses);
var acumulador = 0;

for (double i = 1; i <= numberofhouses; i++)
{
    acumulador += Math.Pow(10,i) + Convert.ToInt32(lista[Convert.ToInt32(i)]); 
}
WriteLine(acumulador);




