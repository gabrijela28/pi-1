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
    public partial class formUciteljGlavni : Form
    {
        public formUciteljGlavni()
        {
            InitializeComponent();
        }

        private void groupKategorijaA_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formUciteljKategorijaA formUciteljA = new formUciteljKategorijaA();
            //this.Close();
            formUciteljA.Show();
        }

        private void menuBtnPostavke_Click(object sender, EventArgs e)
        {
            formUciteljPostavke formUciteljP = new formUciteljPostavke();
            formUciteljP.Show();
        }

        private void menuBtnPredmeti_Click(object sender, EventArgs e)
        {

        }

        private void menuBtnKatC1_Click(object sender, EventArgs e)
        {
            formUciteljKategorijaA formKA = new formUciteljKategorijaA();
            //this.Close();
            formKA.Show();

        }

        private void menuBtnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuBtnKatB_Click(object sender, EventArgs e)
        {

            formUciteljKategorijaA formKA = new formUciteljKategorijaA();
            //this.Close();
            formKA.Show();
        }

        private void sTATISTIKAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUciteljStat formST = new formUciteljStat();
            this.Close();
            formST.Show();
        }
    }
}
