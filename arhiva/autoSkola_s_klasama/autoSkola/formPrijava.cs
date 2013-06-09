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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtKorIme.Text == "ucenik" && txtLozinka.Text == "ucenik")
            {
                formUcenikGlavni frmUcenikGlavni = new formUcenikGlavni();
                frmUcenikGlavni.Show();
                this.Hide();
                
            }
            else if (txtKorIme.Text == "predavac" && txtLozinka.Text == "predavac")
            {
                autoSkola.formUciteljGlavni frmUciteljGlavni = new autoSkola.formUciteljGlavni();
                frmUciteljGlavni.Show();
                this.Hide();
            }
        }
    }
}
