using System;
using System.Linq;
using System.Windows.Forms;

namespace Proiect2_MIP
{
    public partial class VanzareProdus : Form
    {
        private int idProdus;
        private string numeProdus;
        private Cumparare formularCumparare;

        public VanzareProdus(int idProdus, string numeProdus, Cumparare formularCumparare)
        {
            InitializeComponent();
            this.idProdus = idProdus;
            this.numeProdus = numeProdus;
            this.formularCumparare = formularCumparare;
            lblDetaliiProdus.Text = $"Vanzare produs: {numeProdus}";
        }

        private void btnVanzare_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantitate.Text, out int cantitateVanduta))
            {
                using (MagazinProiect2DbContext mdb = new MagazinProiect2DbContext())
                {
                    var produs = mdb.Produse.FirstOrDefault(p => p.Id == idProdus);

                    if (produs != null)
                    {
                        if (cantitateVanduta > 0 && cantitateVanduta <= produs.Cantitate)
                        {
                            produs.Cantitate -= cantitateVanduta;

                            if (produs.Cantitate == 0)
                            {
                                mdb.Produse.Remove(produs);
                            }

                            // creeaza o inregistrare noua in cosul de cumparaturi
                            var shoppingCartItem = new CumparareProd
                            {
                                IdUser = formularCumparare.loggedInUserId,  
                                IdProdus = idProdus,
                                Cantitate = cantitateVanduta
                            };

                            mdb.CumparariProd.Add(shoppingCartItem);

                            mdb.SaveChanges();
                            MessageBox.Show("Vânzare realizată cu succes!");

                            // dupa vanzare, actualizeaza istoricul de cumparaturi
                            formularCumparare.ActualizeazaIstoricVanzari();

                            // actualizeaza cosul de cumparaturi in formularul Cumparare
                            formularCumparare.IncarcaCosCumparaturi();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cantitatea de produse disponibile nu este suficienta pentru vanzare sau cantitatea introdusa nu este valida.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produsul nu a fost gasit!");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Introduceti o cantitate valida!");
            }
        }
    }
}
