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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            using (MagazinProiect2DbContext mdb = new MagazinProiect2DbContext())
            {
                Produs p = new Produs();
                p.Denumire = txtDen.Text;
                p.DescriereProdus = txtDes.Text;
                p.DataIntrare = dtpInMag.Value;
                p.DataValabilitate = dtpTerVal.Value;
                p.Cantitate = (int)nupCant.Value;

                mdb.Produse.Add(p);
                mdb.SaveChanges();
            }

            MessageBox.Show("Produs adaugat cu succes!");
        }
        
        private void btnEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }








    }
}
