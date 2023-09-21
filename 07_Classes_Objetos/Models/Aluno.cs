//O name é um nome em que usaremos para fazer referência quando usarmos
using System.Formats.Asn1;

namespace Sesi.Model
{
    //Declarando class Aluno
    public class Aluno
    {
       //DEclarando os atributos (propriedades) da classe Aluno
       public string nome { get; set; }

       public int idade { get; set; }


       public string turma { get; set; }

//Dalcarando atributo privado
       private int nrFaltas { get; set; }

       //Criando um método

       public void Apresentar()
       {
        Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade} anos e estudo na turma {turma} e tenho {nrFaltas} faltas ");
       }
    
    public void AdicionarFaltas(int nr)
    {
        nrFaltas = nrFaltas + nr;
    }
     
    //Método ResumoFaltas
    

    }
}

