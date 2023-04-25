using static System.Console;

string[] numeros =
            {
                "1 2 3 44 5",
                "55 2 1 854 963 520 1 0 98 8",
                "",
                "2 3 5 44 8 99 6 55 72 3 01 25",
                "98 99 100 101 102 103 105 105",
                "1"
            };

List<string[]> numerosemp = new List<string[]>();
List<int> todosNumeros = new List<int>();
// numerosemphy = numeros;

// foreach (var item in numerosemphy)
// {
//     WriteLine(item);    
// }
foreach (var item in numeros)
{
    numerosemp.Add(item.Split(" "));
}

foreach (var element in numerosemp)
{
    foreach (string item in element)
    {
        if (item != "")
        {
            todosNumeros.Add(int.Parse(item));
        }
        //WriteLine(item);
    }
}
int maximo = todosNumeros.Max();
int soma =  todosNumeros.Sum();

WriteLine($"O maior número é: {maximo}");
WriteLine($"A soma dos itens é: {soma}");
// foreach (var item in numeros)
// {
//     WriteLine(item);
// }