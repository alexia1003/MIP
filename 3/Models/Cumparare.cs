using LanguagesManager;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect3_MIP.Models
{
    public class Cumparare
    {
        [Key]
        public int IdComanda { get; set; }

       // [Display(Name = "Name", ResourceType = typeof(Resource))]
        public string NumeUser { get; set; }

       // [Display(Name = "Order Date", ResourceType = typeof(Resource))]
        public DateTime DataComanda { get; set; }

       // [Display(Name = "Quantity", ResourceType = typeof(Resource))]
        public int Cantitate { get; set; }
        
        [ForeignKey("Produs")]
        public int ProdusId { get; set; }

        public Produs Produs { get; set; }

        public List<Produs> Produse { get; set; }
    }
    
}
