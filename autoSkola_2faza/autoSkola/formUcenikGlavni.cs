using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoSkola
{
    public partial class formUcenikGlavni : Form
    {
        private data podaci = null;
        public formUcenikGlavni()
        {
            InitializeComponent();
        }
        public formUcenikGlavni(data Podaci)
        {
            InitializeComponent();
            podaci = Podaci;
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

        private void formUcenikGlavni_Load(object sender, EventArgs e)
        {
            MessageBox.Show(podaci.Ispit[0].napomena.ToString());
            
            int lokY = 65; //za 93 povećavamo
            for (int i = 0; i < podaci.Predmet.Count; i++)
            {
                GroupBox boxPredmet = new GroupBox();
                boxPredmet.Name = podaci.Predmet[i].naziv.ToString();
                boxPredmet.Size = new Size (760, 76);
                boxPredmet.Location = new Point(12, lokY);
                lokY += 93; //pozicija Y za sljedeci gbox

                boxPredmet.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);

                boxPredmet.Text = podaci.Predmet[i].naziv.ToString();
                boxPredmet.Font = new Font ("Microsoft Sans Serif", 10);

                this.Controls.Add(boxPredmet); 

                //ELEMENTI GROUPBOXa

                //labelovi
                Label lblStatus = new Label();
                lblStatus.Text = "Status: ";
                lblStatus.Location = new Point(7, 28);
                boxPredmet.Controls.Add(lblStatus);

                //status predmeta :(
                int predmetID = podaci.Predmet[i].ID_predmet;

                Label lblVazno = new Label();
                lblVazno.Text = "Važno: ";
                lblVazno.Location = new Point(7, 51);
                boxPredmet.Controls.Add(lblVazno);

                //btn
                Button btnVise = new Button();
                btnVise.Text = "Više";
                btnVise.Location = new Point(679, 44);
                boxPredmet.Controls.Add(btnVise);
            }
            
        }
    }
}
