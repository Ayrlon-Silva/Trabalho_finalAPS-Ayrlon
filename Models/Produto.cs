using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade_ayrlon_dotnet.Models
{
   public class Produto
   {
       [Display(Name = "Id")]
       public int Id { get; set; }
       [Display(Name = "Nome")]
       public string Nome { get; set; }
       [Display(Name = "DESCRICAO")]
       public string Descricao { get; set; }
       [Display(Name = "Quantidade")]
       public int Quantidade { get; set; }
       [Display(Name = "Preco")]
       public double Preco { get; set; }
   }
}
