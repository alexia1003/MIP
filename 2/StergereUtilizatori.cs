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
    public partial class StergereUtilizatori : Form
    {
        public StergereUtilizatori()
        {
            InitializeComponent();
            RefreshUserList();
        }

        private void RefreshUserList()
        {
            using (MagazinProiect2DbContext db = new MagazinProiect2DbContext())
            {
                var users = db.Utilizatori
                    .Select(u => new { u.Id, u.Username, u.Nume, u.Prenume })
                    .ToList();

                dataGVUtilizatori.DataSource = users;
            }
        }

        private void dataGVUtilizatori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnStgUser_Click(object sender, EventArgs e)
        {
            Utilizator selectedUser = GetSelectedUser();
            if (selectedUser != null)
            {
                DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa stergeti acest utilizator?", "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteUserAsync(selectedUser);
                    RefreshUserList();
                }
            }
            else
            {
                MessageBox.Show("Niciun utilizator selectat.", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task DeleteUserAsync(Utilizator user)
        {
            using (MagazinProiect2DbContext db = new MagazinProiect2DbContext())
            {
                var existingUser = await db.Utilizatori.FindAsync(user.Id);

                if (existingUser != null)
                {
                    // sterge obiect
                    db.Utilizatori.Remove(existingUser);

                    // salveaza schimbarile
                    db.SaveChangesAsync();
                }
            }
        }

        private Utilizator GetSelectedUser()
        {
            if (dataGVUtilizatori.SelectedRows.Count > 0)
            {
                int selectedUserId = Convert.ToInt32(dataGVUtilizatori.SelectedRows[0].Cells["Id"].Value);
                using (MagazinProiect2DbContext db = new MagazinProiect2DbContext())
                {
                    return db.Utilizatori.FirstOrDefault(u => u.Id == selectedUserId);
                }
            }

            return null;
        }
    }
}