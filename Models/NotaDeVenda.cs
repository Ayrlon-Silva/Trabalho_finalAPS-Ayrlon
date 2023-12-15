using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade_ayrlon_dotnet.Models
{
   public class NotaDeVenda
   {
       public int Id { get; set; }
       [Display(Name = "Id")]
       public int IdPagamento { get; set; }
       [Display(Name = "Id pagamento")]
       public int IdTransportadora { get; set; }
       [Display(Name = "Id transportadora")]
       public int IdVendedor { get; set; }
       [Display(Name = "Id Vendedor")]
       public int IdCliente { get; set; }
       [Display(Name = "Id Cliente")]
       public DateTime Data { get; set; }
       [Display(Name = "Data")]
       public bool Tipo { get; set; }
       [Display(Name = "Tipo")]
       public virtual ICollection<Item> Items {get; set;}
   }
}