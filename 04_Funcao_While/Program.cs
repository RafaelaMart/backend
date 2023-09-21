class Sesi
{
    //Método Main é o ponto de entrada de um programa em C#
   publicstatic void Main()
   {
 Consoe.WriteLine("Estou no método Main");
   Metodo();
   ImprimeDataHora ();
   ImprimeDataHora ();
    
    int resultadoSoma = Somar(3,8);
    Console.WriteLine(resultadoSoma);
 }

    publicstatic void Main()
   {
 Consoe.WriteLine("Estou no método / função");
   }

   public static void ImprimeDataHora()
   {
    Console.WriteLine(DateTime.Now.ToShotDateString());
     Console.WriteLine(DateTime.Now.Hour.ToString());
      Console.WriteLine(DateTime.Now.ToString());
    
      
   }
    public static void ContagemRegressiva(int n)
    {
        while (n >= 0){
            Console.WriteLine(n);
            n--; // n = n - 1;
            System.Threading.Thread.Sleep(1000); //Pausa de 1s -1000ms
        }
        Console.WriteLine("BOOOOOOOOOOOOM";)

        do{
            Console.WriteLine("Digite um n");
            nrdigitado = int.Parse(Console.ReadLine());
            if (nrDigitado > nrSorteado)
            Console.WriteLine("O número digitado é MAIOR")
            
        }
    }

   public static int Somar(int n1, int n2)
   {
    int soma =n1 + n2;
    return soma;
   }
}