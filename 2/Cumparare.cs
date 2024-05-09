using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2_MIP
{
    public partial class Cumparare : Form
    {
        public int loggedInUserId;

        public Cumparare(int userId)
        {
            InitializeComponent();
            this.loggedInUserId = userId;
            IncarcaIstoricVanzari();
            IncarcaCosCumparaturi();
            // afisare cos de cumparaturi la incarcarea formularului
        }

        public void IncarcaIstoricVanzari()
        {
            using (MagazinProiect2DbContext db = new MagazinProiect2DbContext())
            {
                var istoricVanzari = from s in db.IstoricVanzari
                                     where s.IdUser == loggedInUserId
                                     select new
                                     {
                                         s.Id,
                                         s.DenumireProdus,
                                         s.Cantitate
                                     };


                dgvIstoricVanzare.DataSource = istoricVanzari.ToList();
            }
        }

        public void IncarcaCosCumparaturi()
        {
            using (MagazinProiect2DbContext db = new MagazinProiect2DbContext())
            {
                var cosCumparaturi = from cos in db.CumparariProd
                                     //join u in db.Utilizatori on cos.IdUser equals u.Id
                                     where cos.IdUser == loggedInUserId
                                     select new
                                     {
                                         cos.Id,
                                         //NumeUtilizator = u.Username,
                                         NumeProdus = db.Produse.FirstOrDefault(p => p.Id == cos.IdProdus) != null
                                                      ? db.Produse.FirstOrDefault(p => p.Id == cos.IdProdus).Denumire
                                                      : "Necunoscut",
                                         Cantitate = cos.Cantitate
                                     };
                
                dgvIstoricVanzare.DataSource = cosCumparaturi.ToList();
            }
        }


        public void ActualizeazaIstoricVanzari()
        {
            // reincarcati istoricul de vanzari
            IncarcaIstoricVanzari();
            // actualizati cosul de cumparaturi
            IncarcaCosCumparaturi();
        }

        private void dgvIstoricVanzare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}