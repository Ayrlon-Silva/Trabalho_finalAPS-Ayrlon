using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade_ayrlon_dotnet.Models
{
    public class Cliente
    {
        [Display(Name = "Id cliente")]
        public int Id { get; set; }
        [Display(Name = "Nome cliente")]
        public string Nome { get; set; }
    }
}