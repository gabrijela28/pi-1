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
    public partial class formUcenikGlavni : Form
    {
        public formUcenikGlavni()
        {
            InitializeComponent();
        }

        private void menuBtnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuBtnPostavke_Click(object sender, EventArgs e)
        {
            formUcenikPostavke frmPostavke = new formUcenikPostavke();
            frmPostavke.Show();
        }

        private void btnViseB_Click(object sender, EventArgs e)
        {
            formUcenikBKat frmKatB = new formUcenikBKat();
            this.Close();
            frmKatB.Show();
        }

        private void menuBtnKatB_Click(object sender, EventArgs e)
        {
            formUcenikBKat frmKatB = new formUcenikBKat();
            this.Close();
            frmKatB.Show();
        }

        private void menuBtnKatC1_Click(object sender, EventArgs e)
        {
            formUcenikC1Kat frmKatC1 = new formUcenikC1Kat();
            this.Close();
            frmKatC1.Show();
        }

        private void btnViseC1_Click(object sender, EventArgs e)
        {
            formUcenikC1Kat frmKatC1 = new formUcenikC1Kat();
            this.Close();
            frmKatC1.Show();
        }
    }
}
