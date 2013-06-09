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
    public partial class formUciteljKategorijaA : Form
    {
        public formUciteljKategorijaA()
        {
            InitializeComponent();
        }

        private void kalendarObvezaB_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void formUciteljKategorijaA_Load(object sender, EventArgs e)
        {

        }

        private void lblNaslovB_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formUciteljNRok formUciteljNR = new formUciteljNRok();
            formUciteljNR.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formUciteljNMaterijal formUciteljNMat = new formUciteljNMaterijal();
            formUciteljNMat.Show();
            
        }

        private void btnNCjelina_Click(object sender, EventArgs e)
        {
            formUciteljNCjelina formUciteljNCj = new formUciteljNCjelina();
            formUciteljNCj.Show();
        }

        private void btnEvidencija_Click(object sender, EventArgs e)
        {
            formUciteljNEvidencija formUciteljNE = new formUciteljNEvidencija();
            formUciteljNE.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            formUciteljNPitanje formUciteljNP = new formUciteljNPitanje();
            formUciteljNP.Show();
        }

        private void menuBtnKatC1_Click(object sender, EventArgs e)
        {
            formUciteljKategorijaA formUciteljA = new formUciteljKategorijaA();
            this.Close();
            formUciteljA.Show();

        }

        private void menuBtnKatB_Click(object sender, EventArgs e)
        {

            formUciteljKategorijaA formUciteljA = new formUciteljKategorijaA();
            this.Close();
            formUciteljA.Show();
        }

        private void menuBtnPostavke_Click(object sender, EventArgs e)
        {

            formUciteljPostavke formUciteljA = new formUciteljPostavke();
            //this.Close();
            formUciteljA.Show();
        }

        private void menuBtnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuBtnHome_Click(object sender, EventArgs e)
        {
            formUciteljGlavni formUciteljA = new formUciteljGlavni();
            this.Close();
            formUciteljA.Show();

        }

        private void sTATISTIKAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUciteljStat formST = new formUciteljStat();
            this.Close();
            formST.Show();
        }

        private void menuVertikalni_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}
