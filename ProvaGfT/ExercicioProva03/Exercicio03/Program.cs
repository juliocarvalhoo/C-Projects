using static System.Console; 
using Exercicio03.Agenda;

namespace Exercicio03
{
    public class Program
    {
        static void Main()
        {
            List<Contatos> listaContatos = new List<Contatos>();

            void InserirContato()
            {
                string linha = new string('-',70);
                WriteLine("Insira o nome por favor: ");
                string? iNome = ReadLine()??string.Empty;
                WriteLine("Insira o Número celular: ");
                long iNumero = long.Parse(ReadLine()??string.Empty);
                WriteLine("Insira o sua idade: ");
                int iIdade = int.Parse(ReadLine()??string.Empty);
                listaContatos.Add(new Contatos(iNome,iNumero,iIdade));
                listaContatos = listaContatos.OrderBy(x => x.Nome).ToList();
            }  

            void ExcluirContato()
            {
                string linha = new string('-',70);
                WriteLine("Insira o Nome do contato a excluir");
                WriteLine(linha);
                foreach (Contatos item in listaContatos)
                {
                    WriteLine(item.Nome); 
                    WriteLine("---------");         
                }

                string? nomeDeletar = ReadLine();
                foreach (Contatos item in listaContatos)
                {
                    if(item.Nome.ToString() == nomeDeletar)
                    {
                        listaContatos.Remove(item);
                        break;
                    }
                          
                }

            }  

            void EditarContato()
            {
                string linha = new string('-',70);
                WriteLine("Insira o Nome do contato a editar");
                WriteLine(linha);
                foreach (Contatos item in listaContatos)
                {
                    WriteLine(item.Nome); 
                    WriteLine("---------");         
                }

                string? nomeEditar = ReadLine()??string.Empty;
                foreach (Contatos item in listaContatos)
                {
                    if(item.Nome.ToString() == nomeEditar)
                    {
                        linha = new string('-',70);
                        Console.Clear();
                        Perguntas(); ///
                        listaContatos.Add(new Contatos(eNome,eNumero,eIdade));
                        listaContatos.Remove(item);
                        listaContatos = listaContatos.OrderBy(x => x.Nome).ToList();
                        break;
                    }    
                }

            }  

            while (true)
            {
                Console.Clear();
                WriteLine("O que vossa Majestade deseja? ");

                WriteLine("(1) Adicionar Contato"); 
                WriteLine("(2) Editar Contato");    
                WriteLine("(3) Excluir um Contato");  
                WriteLine(""); 

                WriteLine("(0) Sair...");  
                int opcao = int.Parse(ReadLine()??string.Empty);
                if (opcao == 1)
                {
                    Console.Clear();
                    InserirContato();                    
                }
                else if (opcao == 2)
                {
                    Console.Clear();
                    EditarContato();
                }
                else if (opcao == 3)
                {
                    Console.Clear();
                    ExcluirContato();
                }
                else if (opcao == 0)
                {
                    break;
                }
                else
                {
                    WriteLine("Comando inválido...");
                    WriteLine("-------------------------------------------");
                }


            }
            
            //(nome.this,idade.this, numero.this)

        }
    }
    
}
