public class Program
{
    public static void Main()
    {
        try
        {
         //Gravando arquivos de texto
         using (StreamWriter arquivo = new StreamWriter("arquivo.txt" , true))
         {
            arquivo.WriteLine("Texto 1");
         }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro no arquivo {erro.Message}");
        }
    }

 public void GravarArquivo() 
  public static void Main()
    {
        try
        {
         //Gravando arquivos de texto
         using (StreamWriter arquivo = new StreamWriter("arquivo.txt" , true))
         {
            arquivo.WriteLine("Texto 1");
         }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro no arquivo {erro.Message}");
        }
    }  
    public static void LerArquivo()
    {
        using(StreamWriter arquivo = new StreamWriter("aquivo.txt"))
        {
            string linha;
            while (linha = arquivo.ReadLine() != null)
            {
                Console.WriteLine(linha);
            }

        }
    }
}