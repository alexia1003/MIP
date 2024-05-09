using LanguagesManager;
using System.ComponentModel.DataAnnotations;

namespace Proiect3_MIP.Models
{
    public class Produs
    {
        [Key]
        public int IdProdus { get; set; }

       //[Display(Name = "Nume", ResourceType = typeof(Resource))]
        public string Nume { get; set; }

       // [Display(Name = "Pret", ResourceType = typeof(Resource))]
        public decimal Pret { get; set; }
    }
}
