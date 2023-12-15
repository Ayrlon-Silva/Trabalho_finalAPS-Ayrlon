using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade_ayrlon_dotnet.Models
{
   public class Pagamento
   {
       [Display(Name = "Id")]
       public int Id { get; set; }
       [Display(Name = "Data Limite")]
       public DateTime DataLimite { get; set; }
       [Display(Name = "Valor")]
       public double Valor { get; set; }
       [Display(Name = "Pago")]
       public bool Pago { get; set; }
   }
}