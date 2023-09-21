using System.Collections.Generic;
using Sesi.Models;
using Sesi.Models;

public class Program
{
    public static void Main()
    {
      //Criando uma lista de némeros inteiros
      List<int> listaNumeros = new List<int>();

      //Adicionando elementos à lista
      listaNumeros.Add(10); //posição [0]
      listaNumeros.Add(20); //posição [1]
      listaNumeros.Add(45); //posição [2]

     //Contando a quantidade de elementos em nossa lista
      Console.WriteLine($"Neste momento temos {ListaNumeros.Count} números");
    
    //Acessando os dados da lista pelo índice
    Console.WriteLine(listaNumeros[1]);

    listaNumeros.Add(6); // posicçao [3]
    Console.WriteLine($"Neste momento temos {ListaNumeros.Count} números");
    
    Console.WriteLine("-------------------");

    //Criem uma nova lista de nomes e adicionem algun nomes a ela 
    //exibam a quantidade de nomes que contém nessa lista

    List<string> listaNomes = new List<string>();
    

    listaNomes.Add("Roberto");
    listaNomes.Add("João");
    listaNomes.Add("Fabiano");
    listaNomes.Add("Heitor");

     Console.WriteLine($"Neste momento temos {ListaNomes.Count} nomes");
    
    Console.WriteLine("-------------------");

    //Criando uma lista já atribuindo valores
    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9};
    numeros.Add(10);

    //Iterando sobre todos os itens da lista
    foreach (int item in numeros)
    {
        Console.WriteLine(item);
    }

    foreach (int item in listaNumeros)
    {
        Console.WriteLine(item);
    }
     
    numeros.Remove(2); //Remove elemento buscando pelo conteúdo
    numeros.RemoveAt(4); //Remove elemento pela posição (índice)
    numeros.RemoveRange(2, 2); //Remove elemento da posição 2 e os próximos 2


     foreach (int item in numeros)
    {
        Console.WriteLine(item);
    }
   
   //Criando uma nova lista com objetos da Classe Aluno
   List<Aluno> ListaAlunos = new List<Aluno>();

   //Adicionando um novo aluno à listaAluno
   Aluno novoAluno = new Aluno("Marcos" , 15);
   ListaAlunos.Add(novoAluno);

   ListaAlunos.Add(new Aluno("César", 17));
   ListaAlunos.Add(new Aluno("Patrícia", 19));
     ListaAlunos.Add(new Aluno("Carlos", 17));
   ListaAlunos.Add(new Aluno("Alice", 19));
    

    Console.WriteLine("Lista de Alunos:");
     foreach (Aluno item in ListaAluno)
    {
        Console.WriteLine($"Nome aluno: {intem.nome} idade {item.idade}");
    }

    //Criando uma nova lista, filtrando e ordenando por nome
    //LINQ utilizando Sintaxe de consulta
    var consulta = from aluno in ListaAlunos
                   where aluno.idade > 18
                   orderby aluno.nome
                   select aluno;
     Console.WriteLine("Lista de alunos maiores de 18 anos") ;
     foreach (var item in consulta)
     {
        Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
     } 

     //LINQ ultilizando Sintaxe de método
     var metodo = ListaAlunos
                     .Where(aluno => aluno.idade < 18)
                     .OrderBy(aluno => aluno.nome);
     Console.WriteLine("Lista de alunos menores de 18 anos");
     foreach (var item in metodo)
     {
        Console.WriteLine($"Nome aluno: {item.nome} idadde {item.idade}");
     }                            

    }
}