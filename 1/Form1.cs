using Proiect1_MIP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect1
{
    public partial class Form1 : Form
    {
        private List<string> lstBlock = new List<string>();

        public Form1()
        {
            InitializeComponent();

            ExtrageCuvinteCheieDinBazaDeDate();
            IntroduCuvinteCheieInComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        private void btnGO_Click(object sender, EventArgs e)
        {
            this.webBrowser.Navigate(TextBoxUrl.Text);
        }

        private void TextBoxUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.webBrowser.Navigate(TextBoxUrl.Text);
            }
        }
        private void btnHOME_Click(object sender, EventArgs e)
        {
            this.webBrowser.Navigate("https://www.google.com/");
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
            {
                webBrowser.GoBack();
            }
        }

        private void btnFORWARD_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
            {
                webBrowser.GoForward();
            }
        }

        private async Task ScriereFisierTraceAsync(string mesaj)
        {
            await Task.Run(() =>
            {
                Trace.WriteLine(mesaj);
                using (StreamWriter sw = new StreamWriter("output.txt", true))
                {
                    sw.WriteLine($"{mesaj}");
                }
            });
        }

        private async void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            string url = e.Url.ToString();

            var res = Task.Run(() => AsyncCheckBlock(url));
            res.Wait();

            if (res.Result)
            {
                e.Cancel = true;
                MessageBox.Show("Url blocat!");
                await ScriereFisierTraceAsync($"Url blocat: {url}");
            }
        }

        private async Task<bool> AsyncCheckBlock(string url)
        {
            bool res = await Task.Run(
                async () =>
                {
                    return (from keyword in lstBlock
                            where url.Contains(keyword)
                            select keyword).Count() > 0;
                }
                );

            return res;
        }

        private List<string> ExtrageCuvinteCheieDinBazaDeDate()
        {
            lstBlock.Clear();

            // conectare la BD
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // selectare cuvinte cheie
                string selectKeywordsQuery = "SELECT Keyword FROM Keywords;";
                using (SQLiteCommand selectKeywordsCommand = new SQLiteCommand(selectKeywordsQuery, conn))
                {
                    using (SQLiteDataReader reader = selectKeywordsCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //add cuvant cheie in lista
                            lstBlock.Add(reader["Keyword"].ToString());
                        }
                    }
                }
            }
            return lstBlock;
        }

        public void IntroduCuvinteCheieInComboBox()
        {
            ComboBox.Items.Clear();

            // extragere cuv. ch. din BD
            List<string> cuvinteCheie = ExtrageCuvinteCheieDinBazaDeDate();

            // add cuv. ch. in combobox
            ComboBox.Items.AddRange(lstBlock.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCuvinteCheie cuvch = new AddCuvinteCheie();
            cuvch.ShowDialog();
            //this.Close();

            IntroduCuvinteCheieInComboBox();
        }

        private void TextBoxUrl_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox_Click(object sender, EventArgs e)
        {

        }
    }
}
