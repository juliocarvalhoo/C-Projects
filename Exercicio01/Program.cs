using static System.Console;

WriteLine("Insira um número qualquer: ");
string? numberString = "456";
List<char> lista = new List<char>();

foreach (char item in numberString)
{
    lista.Add(item);
}
int numeroCasas = lista.Count();
var acumulador=0.0;
foreach (var element in lista)
{
    WriteLine(element);
}
// var potencianumber = Math.Pow(numeroCasas,2);
// WriteLine(potencianumber);

for (int i = 0; i < numeroCasas; i++)
{
    acumulador += Math.Pow(10,i) * Convert.ToInt32(lista[i].ToString());
}
WriteLine(acumulador);
