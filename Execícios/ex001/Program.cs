//Receber o nome do aluno e armazenar em uma variavel do tipo string
 Console.WriteLine("Informe o nome do aluno:");
 string aluno = Console.ReadLine();

//Receber a nota 1, converter e armazenar em uma variável int
Console.WriteLine("Digite a nota 1:");
int nota1 = int.Parse(Console.ReadLine());


//Receber a nota 2, converter e armazenar em uma variável int
Console.WriteLine("Digite a nota 2");
int n2 = int.Parse(Console.ReadLine());
 
//Receber a nota 3, converter e armazenar em uma variável int
Console.WriteLine("Digite a nota 3");
int n2 = int.Parse(Console.ReadLine());

//Declarar uma variável do tipo int,para recber a média das notas
int notas = (nota1 + n2 + n3) / 3
string media = (notas >=7) ? "PASSOU" : "REPROVADO";

Console.WriteLine(media);