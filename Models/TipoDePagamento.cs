using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade_ayrlon_dotnet.Models
{
   public class TipoDePagamento
   {
       [Display(Name = "Id")]
       public int Id { get; set; }
       [Display(Name = "Nome do Cobrado")]
       public string NomeDoCobrado { get; set; }
       [Display(Name = "Informacoes Adcionais")]
       public string InformacoesAdcionais { get; set; }
   }
}