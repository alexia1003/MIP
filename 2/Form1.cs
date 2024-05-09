using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2_MIP
{
    public partial class Form1 : Form
    {
        private int loggedInUserId = -1; 
        // -1 -> nici un utilizator autentificat

        public Form1(int loggedInUserId)
        {
            InitializeComponent();
            this.loggedInUserId = loggedInUserId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e) 
        {
            using (MagazinProiect2DbContext db = new MagazinProiect2DbContext())
            {
                var res = from s in db.Produse
                          select new
                          {
                              s.Id,
                              s.Denumire,
                              s.Cantitate
                          };
                dataGVProduse.DataSource = res.ToList();
            }
        }

        private async void dataGVProduse_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {  
            int id = int.Parse(dataGVProduse.Rows[e.RowIndex].Cells["Id"].Value.ToString());

            using (MagazinProiect2DbContext mdb = new MagazinProiect2DbContext())
            {
                var product = await mdb.Produse.SingleOrDefaultAsync(x => x.Id == id);

                if (product != null)
                {
                    product.Cantitate--;

                    if (product.Cantitate == 0)
                    {
                        mdb.Produse.Remove(product);
                    }

                    await mdb.SaveChangesAsync();
                    btnRefresh_Click(sender, e);
                }
            }

            string numeProdus = dataGVProduse.Rows[e.RowIndex].Cells["Denumire"].Value.ToString();

            Cumparare cumparareForm = new Cumparare(loggedInUserId);
            VanzareProdus vanzareProdusForm = new VanzareProdus(id, numeProdus, cumparareForm);
            vanzareProdusForm.Show();
        }
 
        private void btnSearch_Click(object sender, EventArgs e)
        { 
            string src = txtSearch.Text;

            using (MagazinProiect2DbContext db = new MagazinProiect2DbContext())
            {
                var res = from s in db.Produse
                          where s.Denumire.Contains(src)

                          select new
                          {
                              s.Id,
                              s.Denumire,
                              s.Cantitate
                          };
                dataGVProduse.DataSource = res.ToList();
            }
        }

        private void vanzareToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Cumparare cumparareForm = new Cumparare(loggedInUserId);

            if (dataGVProduse.SelectedRows.Count > 0)
            {
                // obtinem informatii despre produsul selectat
                int idProdus = Convert.ToInt32(dataGVProduse.SelectedRows[0].Cells["Id"].Value);
                string numeProdus = dataGVProduse.SelectedRows[0].Cells["Denumire"].Value.ToString();

                // deschidem fereastra VanzareProdus
                VanzareProdus vanzareProdusForm = new VanzareProdus(idProdus, numeProdus, cumparareForm);
                vanzareProdusForm.ShowDialog();

                // actualizare coninut dgv 
                btnRefresh_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Selectati un produs pentru a-l vinde.", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }      

        private void cumparareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // deschide formularul Cumparare si introdu ID utilizator
            Cumparare cumparareForm = new Cumparare(loggedInUserId);
            cumparareForm.ShowDialog();

        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGVProduse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

