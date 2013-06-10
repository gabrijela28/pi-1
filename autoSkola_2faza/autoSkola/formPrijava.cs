using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoSkola
{
    public partial class formPrijava : Form
    {
        public formPrijava()
        {
            InitializeComponent();
        }
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            korisnik Korisnik = new korisnik();
            string korisnikTip = Korisnik.Provjera(txtKorIme.Text, txtLozinka.Text);
            var podaci =new data(txtKorIme.Text, txtLozinka.Text);
            MessageBox.Show(podaci.Korisnik[0].korisnicko_ime.ToString()); 
        }
    }
}
