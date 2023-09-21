﻿class Program 
{
    public static string[] poltronas = new string[51];
    
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bem-vindo ao SesiBus ");
        Console.WriteLine("---------------------");
        Console.WriteLine("Contamos com 50 lugares disponíveis");

        Menu();
        
    }

    public static void Menu(){
        string opcao = "";
        
       ContaCorrente1 conta = new ContaCorrente1(titular)

        do {
            Console.WriteLine("######### M E N U ##########");
            Console.WriteLine("1- Para comprar passagem");
            Console.WriteLine("2- Para poltronas disponíveis");
            Console.WriteLine("3- Quantidade de poltronas disponíveis");
            Console.WriteLine("4- Lista de passageiros");
            Console.WriteLine("0- Para fechar sistema");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao){
                case "0":
                    Console.WriteLine("Obrigado, volte sempre !!!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    ComprarPassagem();
                    break;
                case "2":
                    PoltronasDisponiveis();
                    break;
                case "3":
                    QuantidadeDisponivel();
                    break;
                case "4":
                    ListaPassageiros();
                    break;
                default:
                    Console.WriteLine("Opção inválida!!!");
                    break;
            }


        } while (opcao != "0");

    }

    public static void ComprarPassagem(){
        Console.WriteLine("Quantas passagens deseja comprar?");
        int nrPassagens = int.Parse(Console.ReadLine());

        for (int i= 1; i <= nrPassagens; i++){
            Console.WriteLine($"Digite a poltrona da {i}ª passagem:");
            int nrPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do passageiro:");
            string nome = Console.ReadLine();
            MarcarPoltrona(nrPoltrona, nome);
        }
    }

    public static void MarcarPoltrona(int nrPoltrona, string nome){
        poltronas[nrPoltrona] = nome;
    }

    public static void PoltronasDisponiveis(){
        Console.WriteLine("Lista de Poltronas disponíveis");
        for (int i = 1; i <= 50; i++){
            if (poltronas[i] == null){
                Console.WriteLine($"Nº {i}");
            }
        }
    }
    public static void QuantidadeDisponivel(){
        int total = 0;
        //for (int i = 1; i <= 50; i++){
        //    if (poltronas[i] == null){
        //        total = total + 1;  //total++
        //    }
        //}
        foreach (string item in poltronas){
            //total = (item == null) ? total += 1 : total += 0;  
            if (item == null)
                total = total + 1;
        }
        Console.WriteLine("Atualmente temos " + total + " poltronas disponíveis");
    }

    public static void ListaPassageiros(){
        Console.WriteLine("Lista de Passageiros");
        for (int i = 1; i <= 50; i++){
            if (poltronas[i] != null){
                Console.WriteLine($"Nº {i} - Nome: {poltronas[i]}");
            }
        }
    }


    //public static void ListaPassageiros(){
        // foreach (string item in poltronas){
        //     if (item != null)
        //         Console.WriteLine($"Nome: {item}");
        // }
                       
    //}

}

