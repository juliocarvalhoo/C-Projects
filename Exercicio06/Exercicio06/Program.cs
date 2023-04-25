using static System.Console;

WriteLine("Tamanho do vetor:");
int tamanhoLista = int.Parse(ReadLine());
WriteLine($"Insira {tamanhoLista} numeros: ");

List<int> listNumeros =  new List<int>();
List<int> listPares =  new List<int>();
List<int> listImpares =  new List<int>();

for (int i = 0;  i < tamanhoLista; i++)
{
    int numero = int.Parse(ReadLine().ToString());
    listNumeros.Add(numero);
    if (numero%2==0)
    {
        listPares.Add(numero);
    }
    else
        listImpares.Add(numero);
}
WriteLine($"Quantidade de pares: {listPares.Count()}");
WriteLine($"Quantidade de ímpares: {listImpares.Count()}");

var listanova = listNumeros.GroupBy(item=>item)
                            .Where(item=>item.Count()>1)
                            .Select(item=>item.Key)
                            .ToList();

int contador =0;

foreach (var item in listanova)
{    
    contador =0;
    foreach (var element in listNumeros)
    {        
        if(element == item)
        {
            contador+=1;
        }   
       
    }  
    WriteLine($"Números {item} repetidos = {contador}"); 
}