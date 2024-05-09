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
    public partial class AddUtilizator : Form
    {
        public AddUtilizator()
        {
            InitializeComponent();
        }

        private async void btnAddU_Click(object sender, EventArgs e)
        {
            // obt. datele de la utilizator
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string nume = txtNume.Text;
            string prenume = txtPrenume.Text;

            // validare input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(nume) || string.IsNullOrWhiteSpace(prenume))
            {
                MessageBox.Show("Completati toate campurile!");
                return;
            }

            // crearea unui obiect Utilizator
            Utilizator newUser = new Utilizator
            {
                Username = username,
                Parola = password,
                Nume = nume,
                Prenume = prenume
            };

            // adaugarea utilizatorului in baza de date
            await AddUserAsync(newUser);

            MessageBox.Show("Utilizator adaugat cu succes!");
            this.Close();
        }

        private async Task AddUserAsync(Utilizator user)
        {
            using (MagazinProiect2DbContext db = new MagazinProiect2DbContext())
            {
                db.Utilizatori.Add(user);
                await db.SaveChangesAsync();
            }
        }


    }
}
