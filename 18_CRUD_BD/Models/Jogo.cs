using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _18_CRUD_BD.Models
{
    //DataAnnotaion de como será criado o nome na tabela do BD
    [Table("Jogos")]

    public class Jogo {

      [Key] //Falando para o BD que este atributo será uma chave

    public int JogoId { get; set;}
     public string Nome{ get; set;}
    public string Descrição { get; set;}
    public string Imagem { get; set;}
    public bool Ativo { get; set;}
    }
}
