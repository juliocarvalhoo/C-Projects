using static System.Console;

//Elabora um sistema que leia três valores (A, B, C) e mostre-os na ordem 
//lida. Em seguida, mostre-os em ordem crescente e decrescente.

WriteLine("Insira Três Valores:");
double valor1 = double.Parse(ReadLine());
double valor2 = double.Parse(ReadLine());
double valor3 = double.Parse(ReadLine());


WriteLine($"Primeiro número:{valor1}");
WriteLine($"segundo número:{valor2}");
WriteLine($"terceiro número:{valor3}");

List<double> listaValores = new List<double>(3);
listaValores.Add(valor1);
listaValores.Add(valor2);
listaValores.Add(valor3);

listaValores.Sort();

WriteLine($"----------------------------");
WriteLine($"Ordem Crescente:");
var linha = string.Join(",",listaValores);
WriteLine(linha);
WriteLine($"----------------------------");
WriteLine($"Ordem Decrescente:");
listaValores.Reverse();
var linha2 = string.Join(",",listaValores);
WriteLine(linha2);

