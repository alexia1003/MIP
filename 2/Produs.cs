using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace Proiect2_MIP
{
    public class Produs 
    {
        public int Id { get; set; }
        [MaxLength(30, ErrorMessage = "Maxim 30 de carctere!")]
        
        public string Denumire { get; set; }
        [MaxLength(200, ErrorMessage = "Maxim 200 de carctere!")]
        
        public string DescriereProdus { get; set; }

        public DateTime DataIntrare { get; set; }
        
        public DateTime DataValabilitate { get; set; }

        public int Cantitate { get; set; }
    }



    public class Utilizator 
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Username { get; set; }
        public string Parola { get; set; }

        // leg. cu IstoricVanzari
        public ICollection<IstoricVanzari> IstoricVanzari { get; set; }
    }

    public class IstoricVanzari
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string DenumireProdus { get; set; }
        public int Cantitate { get; set; }
        
        // cheie externa catre Utilizator
        public Utilizator Utilizator { get; set; }

    }

    public class CumparareProd
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdProdus { get; set; }
        public int Cantitate { get; set; }

        // chei externe catre Utilizator și Produs
        public Utilizator Utilizator { get; set; }
        public Produs Produs { get; set; }
    }



    public class MagazinProiect2DbContext : DbContext
    {
        public DbSet<Produs> Produse { get; set; } 

        public DbSet<Utilizator> Utilizatori { get; set; }
        
        public DbSet<IstoricVanzari> IstoricVanzari { get; set; }

        public DbSet<CumparareProd> CumparariProd { get; set; }

        // adaugare utilizator in bd
        public void AdaugaUtilizator(Utilizator utilizator)
        {
            Utilizatori.Add(utilizator);
            SaveChanges();
        }

        // sterge utilizator din bd
        public void StergeUtilizator(Utilizator utilizator)
        {
            Utilizatori.Remove(utilizator);
            SaveChanges();
        }

        // autentificare utilizator
        public bool AutentificareUtilizator(string username, string parola)
        {
            return Utilizatori.Any(u => u.Username == username && u.Parola == parola);
        }



    }

}
