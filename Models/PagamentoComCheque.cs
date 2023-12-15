using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade_ayrlon_dotnet.Models
{
   public class PagamentoComCheque : TipoDePagamento
   {
       [Display(Name = "Banco")]
       public int Banco { get; set; }
       [Display(Name = "Nome do Banco")]
       public string NomeDoBanco { get; set; }
   }
}