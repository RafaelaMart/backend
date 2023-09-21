using Models;

public class Progam
{
     public static void Menu()
    {
        Console.WriteLine("Digite seu nome:");
        string nomeTitular

        string opcao = "";

        do
        {

            Console.WriteLine("###### MENU ######");
            Console.WriteLine(" 1-Para ver o seu saldo");
            Console.WriteLine("2-Para realizar um deposito");
            Console.WriteLine("3-Sacar seu dinheiro");
            Console.WriteLine("0-Sair");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado, Volte sempre.");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    ComprarPassagem();
                    break;
                case "2":
                    PoltronasDisponiveis();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }

        } while (opcao != "0");


    }

}
