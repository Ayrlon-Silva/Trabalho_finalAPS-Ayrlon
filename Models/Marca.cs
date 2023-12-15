using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade_ayrlon_dotnet.Models
{
    public class Marca
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}