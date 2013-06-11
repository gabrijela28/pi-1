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
            

            var podaci = new data();
            if (korisnikTip == null)
                MessageBox.Show("Korisnik ne postoji!");
            else
            {
                podaci = new data(txtKorIme.Text, txtLozinka.Text, korisnikTip);
                this.Hide();
                
                if (korisnikTip == "Učenik")
                {
                    formUcenikGlavni frmUcenikGlavni = new formUcenikGlavni(podaci);
                    
                    frmUcenikGlavni.Show();
                    
                }
                else if (korisnikTip == "Predavač" || korisnikTip == "Instruktor")
                {
                    formUciteljGlavni frmUciteljGlavni = new formUciteljGlavni();
                    frmUciteljGlavni.Show();
                }
                ///<summary>
                /// back je dretva koja periodično provjerava postoje li promjene u klasama i ažurira ih
                ///</summary>
                System.Threading.Thread back;
                var ba = new updateDB();
                ba.DT = podaci;
                back = new System.Threading.Thread(ba.startUpdateDB);
                back.Start();
                 
            }

            

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
