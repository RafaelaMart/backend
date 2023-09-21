class ex005{
public static void Main ()
{
    //Chamar Método
}




}

 public static voud ListaDoChurrasco(){
      //Declarar o vetor com 6 posições tipo string
string[] ListaProdutos = new string;

       //Receber os produtos que precisam ser comprados
       ListaProdutos[0] = "Carne 3kg";
       for (int i = 0; i <ListaProdutos.Length; i++)
     {
        Console.WriteLine("Informe o produto:");
        string produto = Console.ReadLine ();
        ListaProdutos[i] = produto;
     }

     //Ordenar vetor
     Array.Sort(ListaProdutos);

     //"Para cada" item na lista exisbir no console
     foreach (string item in ListaProdutos){
        Console.WriteLine($"Item {item}");
     }

     public static void SonhosDeConsumo(){
     {
      Console.WriteLine("Informe o valor:");
        int valor = Console.ReadLine ();
        ListaProdutos[i] = valor;
      
      foreach (int item in ListaSonhos)
        soma += item;

        Console.WriteLine ($"Seus sonhos custarão R$ {soma}");


     }
 }