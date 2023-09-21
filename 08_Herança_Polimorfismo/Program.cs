using Sesi.Models;

class Program
{
    public static void Main()
    {
        Gato meuGato = new Gato();
        meuGato.nome =  "Charlie";
        meuGato.cor =  "Preto" ;
        meuGato.idade = 6;
        meuGato.especie = "vira lata";
        meuGato.genero = "macho";
        meuGato.peso = 1;

       Peixe meuPeixe = new Peixe();
       meuPeixe.especie = "Palhaço";
       meuPeixe.cor = "Laranja";
       meuPeixe.cor = "Laranja";
       meuPeixe.peso = 0.100M;
    }
}