using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade_ayrlon_dotnet.Models
{
   public class Vendedor
   {
       [Display(Name = "Id")]
       public int Id { get; set; }
       [Display(Name = "Nome")]
       public string Nome { get; set; }
   }
}