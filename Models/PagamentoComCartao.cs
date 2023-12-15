using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade_ayrlon_dotnet.Models
{
   public class PagamentoComCartao : TipoDePagamento
   {
       [Display(Name = "Bandeira")]
       public string Bandeira { get; set; }
       [Display(Name = "Numero do Cartao")]
       public string NumeroDoCartao { get; set; }
   }
}