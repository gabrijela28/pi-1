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
    public partial class formUcenikC1Kat : Form
    {
        public formUcenikC1Kat()
        {
            InitializeComponent();
        }

        private void menuBtnHome_Click(object sender, EventArgs e)
        {
            formUcenikGlavni frmUcenikGlavni = new formUcenikGlavni();
            this.Close();
            frmUcenikGlavni.Show();
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

        private void menuBtnPostavke_Click(object sender, EventArgs e)
        {
            formUcenikPostavke frmPostavke = new formUcenikPostavke();
            frmPostavke.Show();
        }

        private void menuBtnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTeorijaMaterijali_Click(object sender, EventArgs e)
        {
            formUcenikC1Materijali frmC1Materijali = new formUcenikC1Materijali();
            this.Close();
            frmC1Materijali.Show();
        }

        private void btnTeorijaProbno_Click(object sender, EventArgs e)
        {
            formUcenikC1ProbniTest frmC1ProbniTest = new formUcenikC1ProbniTest();
            this.Close();
            frmC1ProbniTest.Show();
        }
    }
}
