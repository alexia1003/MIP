using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect1
{
    public partial class AddCuvinteCheie : Form
    {
        public AddCuvinteCheie()
        {
            InitializeComponent();
        }

        private void AdaugaCuvantCheieInBazaDeDate(string cuvantCheie)
        {
            // conectare la BD
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // add cuv. cheie in tabel
                string insertKeywordQuery = "INSERT INTO Keywords (Keyword) VALUES (@Keyword);";
                using (SQLiteCommand insertKeywordCommand = new SQLiteCommand(insertKeywordQuery, conn))
                {
                    insertKeywordCommand.Parameters.AddWithValue("@Keyword", cuvantCheie);
                    insertKeywordCommand.ExecuteNonQuery();
                }
            }
        }
        
         private void btnAddCuvCh_Click(object sender, EventArgs e)
         {
             // cuv. ch. din textbox
             string cuvantCheie = txtCuvCh.Text;

             // add cuv. ch. in BD
             AdaugaCuvantCheieInBazaDeDate(cuvantCheie);

             // add cuv. ch. in combobox
             Form1 form = new Form1();
             form.IntroduCuvinteCheieInComboBox();

             txtCuvCh.Clear();

             MessageBox.Show("Cuvant adaugat cu succes!");
         }

        private void txtCuvCh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
