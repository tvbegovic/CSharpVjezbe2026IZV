using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ListaRijeci
{
    public partial class Glavna : Form
    {
        List<string> rijeci = new List<string>();
        public Glavna()
        {
            InitializeComponent();
        }

        // ZADATAK: Ovdje deklarirajte listu riječi koju će koristiti sve metode.
        // Handleri su već povezani s gumbima. Dopunjavajte tijela metoda.
        private void btnDodajNaKraj_Click(object sender, EventArgs e)
        {
            // ZADATAK: Dodajte tekst iz txtJednaRijec na kraj liste i osvježite prikaz.
            string rijec = txtJednaRijec.Text;
            rijeci.Add(rijec);
            txtJednaRijec.Clear();
            txtJednaRijec.Focus();
            AzurirajListbox();
        }

        void AzurirajListbox()
        {
            lstPopis.DataSource = null;
            lstPopis.DataSource = rijeci;
        }

        private void btnDodajNaPoziciju_Click(object sender, EventArgs e)
        {
            // ZADATAK: Provjerite txtPozicija, umetnite riječ na zadani indeks i osvježite prikaz.
            string rijec = txtJednaRijec.Text;
            bool ok = int.TryParse(txtPozicija.Text, out int pozicija);
            if(!ok)
            {
                MessageBox.Show("Pogrešan format");
                return;
            }
            if(pozicija < 0 || pozicija > rijeci.Count - 1)
            {
                MessageBox.Show("Pozicija je izvan raspona");
                return;
            }
            rijeci.Insert(pozicija, rijec);
            txtJednaRijec.Clear();
            txtPozicija.Clear();
            AzurirajListbox();
        }

        private void btnDodajVise_Click(object sender, EventArgs e)
        {
            // ZADATAK: Razdvojite txtViseRijeci po razmacima, dodajte riječi u listu i osvježite prikaz.
            string textViseRijeci = txtViseRijeci.Text;
            string[] poljeViseRijeci = textViseRijeci.Split(' ');
            rijeci.AddRange(poljeViseRijeci);
            AzurirajListbox();
            txtViseRijeci.Clear();
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            // ZADATAK: Ako je stavka u lstPopis odabrana, uklonite je iz liste i osvježite prikaz.
            int index = lstPopis.SelectedIndex;
            if(index >= 0)
            {
                rijeci.RemoveAt(index);
                AzurirajListbox();
            }
        }

        private void btnIsprazniListu_Click(object sender, EventArgs e)
        {
            // ZADATAK: Uklonite sve riječi iz liste i osvježite prikaz.
            rijeci.Clear();
            AzurirajListbox();
        }

       
    }
}