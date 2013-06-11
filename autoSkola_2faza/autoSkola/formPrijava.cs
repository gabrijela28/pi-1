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
            MessageBox.Show(korisnikTip);

            var podaci = new data();
            if (korisnikTip == null)
                MessageBox.Show("Korisnik ne postoji!");
            else
            {
                podaci = new data(txtKorIme.Text, txtLozinka.Text);
                this.Hide();
                MessageBox.Show("hide() prolazi!");
                if (korisnikTip == "Učenik")
                {
                    formUcenikGlavni frmUcenikGlavni2 = new formUcenikGlavni();
                    
                    frmUcenikGlavni2.ShowDialog();
                    MessageBox.Show("dddd22");
                }
                else if (korisnikTip == "Predavač" || korisnikTip == "Instruktor")
                {
                    formUciteljGlavni frmUciteljGlavni = new formUciteljGlavni();
                    frmUciteljGlavni.Show();
                }
                
                 
            }

            //MessageBox.Show(podaci.Korisnik[0].korisnicko_ime.ToString()); 

        }
        /// <summary>
        /// "overrajdamo" (ne znam hrvatski!) Close (x) btn!
        /// </summary>
        /// <param name="e"> form closing event</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            baza.Instanca.Zatvori();
        }

        private void formPrijava_Load(object sender, EventArgs e)
        {

        }
    }
}
