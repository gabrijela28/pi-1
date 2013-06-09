namespace autoSkola
{
    partial class formUcenikC1Kat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUcenikC1Kat));
            this.menuVertikalni = new System.Windows.Forms.MenuStrip();
            this.menuBtnHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnPredmeti = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnKatB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnKatC1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnPostavke = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNaslovC1 = new System.Windows.Forms.Label();
            this.kalendarObvezaC1 = new System.Windows.Forms.MonthCalendar();
            this.groupTeorijaC1 = new System.Windows.Forms.GroupBox();
            this.btnTeorijaIspit = new System.Windows.Forms.Button();
            this.btnTeorijaEvidencija = new System.Windows.Forms.Button();
            this.btnTeorijaProbno = new System.Windows.Forms.Button();
            this.btnTeorijaMaterijali = new System.Windows.Forms.Button();
            this.lblIspitC1Teorija2 = new System.Windows.Forms.Label();
            this.lblIspitBTeorija = new System.Windows.Forms.Label();
            this.lblStatusC1Teorija2 = new System.Windows.Forms.Label();
            this.lblStatusC1Teorija = new System.Windows.Forms.Label();
            this.groupPrvaPomocC1 = new System.Windows.Forms.GroupBox();
            this.lblStatusPomocC12 = new System.Windows.Forms.Label();
            this.btnPomocEvidencija = new System.Windows.Forms.Button();
            this.lblStatusPomocC1 = new System.Windows.Forms.Label();
            this.btnPomocMaterijali = new System.Windows.Forms.Button();
            this.groupVoznjaC1 = new System.Windows.Forms.GroupBox();
            this.btnVoznjaIspit = new System.Windows.Forms.Button();
            this.lblStatusVoznjaC12 = new System.Windows.Forms.Label();
            this.btnVoznjaEvidencija = new System.Windows.Forms.Button();
            this.lblStatusVoznjaC1 = new System.Windows.Forms.Label();
            this.menuVertikalni.SuspendLayout();
            this.groupTeorijaC1.SuspendLayout();
            this.groupPrvaPomocC1.SuspendLayout();
            this.groupVoznjaC1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuVertikalni
            // 
            this.menuVertikalni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnHome,
            this.menuBtnPredmeti,
            this.menuBtnPostavke,
            this.menuBtnIzlaz});
            this.menuVertikalni.Location = new System.Drawing.Point(0, 0);
            this.menuVertikalni.Name = "menuVertikalni";
            this.menuVertikalni.Size = new System.Drawing.Size(784, 24);
            this.menuVertikalni.TabIndex = 2;
            this.menuVertikalni.Text = "menuVertikalni";
            // 
            // menuBtnHome
            // 
            this.menuBtnHome.AutoSize = false;
            this.menuBtnHome.Image = ((System.Drawing.Image)(resources.GetObject("menuBtnHome.Image")));
            this.menuBtnHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.menuBtnHome.Name = "menuBtnHome";
            this.menuBtnHome.Size = new System.Drawing.Size(22, 17);
            this.menuBtnHome.Click += new System.EventHandler(this.menuBtnHome_Click);
            // 
            // menuBtnPredmeti
            // 
            this.menuBtnPredmeti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnKatB,
            this.menuBtnKatC1});
            this.menuBtnPredmeti.Name = "menuBtnPredmeti";
            this.menuBtnPredmeti.Size = new System.Drawing.Size(74, 20);
            this.menuBtnPredmeti.Text = "PREDMETI";
            // 
            // menuBtnKatB
            // 
            this.menuBtnKatB.Name = "menuBtnKatB";
            this.menuBtnKatB.Size = new System.Drawing.Size(152, 22);
            this.menuBtnKatB.Text = "B kategorija";
            this.menuBtnKatB.Click += new System.EventHandler(this.menuBtnKatB_Click);
            // 
            // menuBtnKatC1
            // 
            this.menuBtnKatC1.Name = "menuBtnKatC1";
            this.menuBtnKatC1.Size = new System.Drawing.Size(152, 22);
            this.menuBtnKatC1.Text = "C1 kategorija";
            this.menuBtnKatC1.Click += new System.EventHandler(this.menuBtnKatC1_Click);
            // 
            // menuBtnPostavke
            // 
            this.menuBtnPostavke.Name = "menuBtnPostavke";
            this.menuBtnPostavke.Size = new System.Drawing.Size(76, 20);
            this.menuBtnPostavke.Text = "POSTAVKE";
            this.menuBtnPostavke.Click += new System.EventHandler(this.menuBtnPostavke_Click);
            // 
            // menuBtnIzlaz
            // 
            this.menuBtnIzlaz.Checked = true;
            this.menuBtnIzlaz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuBtnIzlaz.Name = "menuBtnIzlaz";
            this.menuBtnIzlaz.Size = new System.Drawing.Size(50, 20);
            this.menuBtnIzlaz.Text = "IZLAZ";
            this.menuBtnIzlaz.Click += new System.EventHandler(this.menuBtnIzlaz_Click);
            // 
            // lblNaslovC1
            // 
            this.lblNaslovC1.AutoSize = true;
            this.lblNaslovC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslovC1.Location = new System.Drawing.Point(16, 33);
            this.lblNaslovC1.Name = "lblNaslovC1";
            this.lblNaslovC1.Size = new System.Drawing.Size(191, 31);
            this.lblNaslovC1.TabIndex = 7;
            this.lblNaslovC1.Text = "Kategorija C1";
            // 
            // kalendarObvezaC1
            // 
            this.kalendarObvezaC1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.kalendarObvezaC1.Location = new System.Drawing.Point(573, 33);
            this.kalendarObvezaC1.Name = "kalendarObvezaC1";
            this.kalendarObvezaC1.TabIndex = 6;
            // 
            // groupTeorijaC1
            // 
            this.groupTeorijaC1.Controls.Add(this.btnTeorijaIspit);
            this.groupTeorijaC1.Controls.Add(this.btnTeorijaEvidencija);
            this.groupTeorijaC1.Controls.Add(this.btnTeorijaProbno);
            this.groupTeorijaC1.Controls.Add(this.btnTeorijaMaterijali);
            this.groupTeorijaC1.Controls.Add(this.lblIspitC1Teorija2);
            this.groupTeorijaC1.Controls.Add(this.lblIspitBTeorija);
            this.groupTeorijaC1.Controls.Add(this.lblStatusC1Teorija2);
            this.groupTeorijaC1.Controls.Add(this.lblStatusC1Teorija);
            this.groupTeorijaC1.Location = new System.Drawing.Point(12, 216);
            this.groupTeorijaC1.Name = "groupTeorijaC1";
            this.groupTeorijaC1.Size = new System.Drawing.Size(760, 90);
            this.groupTeorijaC1.TabIndex = 8;
            this.groupTeorijaC1.TabStop = false;
            this.groupTeorijaC1.Text = "TEORIJA";
            // 
            // btnTeorijaIspit
            // 
            this.btnTeorijaIspit.Enabled = false;
            this.btnTeorijaIspit.Location = new System.Drawing.Point(394, 61);
            this.btnTeorijaIspit.Name = "btnTeorijaIspit";
            this.btnTeorijaIspit.Size = new System.Drawing.Size(96, 23);
            this.btnTeorijaIspit.TabIndex = 7;
            this.btnTeorijaIspit.Text = "Pristupi ispitu";
            this.btnTeorijaIspit.UseVisualStyleBackColor = true;
            // 
            // btnTeorijaEvidencija
            // 
            this.btnTeorijaEvidencija.Location = new System.Drawing.Point(679, 61);
            this.btnTeorijaEvidencija.Name = "btnTeorijaEvidencija";
            this.btnTeorijaEvidencija.Size = new System.Drawing.Size(75, 23);
            this.btnTeorijaEvidencija.TabIndex = 6;
            this.btnTeorijaEvidencija.Text = "Evidencija";
            this.btnTeorijaEvidencija.UseVisualStyleBackColor = true;
            // 
            // btnTeorijaProbno
            // 
            this.btnTeorijaProbno.Location = new System.Drawing.Point(496, 61);
            this.btnTeorijaProbno.Name = "btnTeorijaProbno";
            this.btnTeorijaProbno.Size = new System.Drawing.Size(96, 23);
            this.btnTeorijaProbno.TabIndex = 5;
            this.btnTeorijaProbno.Text = "Probno testiranje";
            this.btnTeorijaProbno.UseVisualStyleBackColor = true;
            this.btnTeorijaProbno.Click += new System.EventHandler(this.btnTeorijaProbno_Click);
            // 
            // btnTeorijaMaterijali
            // 
            this.btnTeorijaMaterijali.Location = new System.Drawing.Point(598, 61);
            this.btnTeorijaMaterijali.Name = "btnTeorijaMaterijali";
            this.btnTeorijaMaterijali.Size = new System.Drawing.Size(75, 23);
            this.btnTeorijaMaterijali.TabIndex = 4;
            this.btnTeorijaMaterijali.Text = "Materijali";
            this.btnTeorijaMaterijali.UseVisualStyleBackColor = true;
            this.btnTeorijaMaterijali.Click += new System.EventHandler(this.btnTeorijaMaterijali_Click);
            // 
            // lblIspitC1Teorija2
            // 
            this.lblIspitC1Teorija2.AutoSize = true;
            this.lblIspitC1Teorija2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblIspitC1Teorija2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblIspitC1Teorija2.Location = new System.Drawing.Point(60, 54);
            this.lblIspitC1Teorija2.Name = "lblIspitC1Teorija2";
            this.lblIspitC1Teorija2.Size = new System.Drawing.Size(0, 16);
            this.lblIspitC1Teorija2.TabIndex = 3;
            // 
            // lblIspitBTeorija
            // 
            this.lblIspitBTeorija.AutoSize = true;
            this.lblIspitBTeorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblIspitBTeorija.Location = new System.Drawing.Point(16, 54);
            this.lblIspitBTeorija.Name = "lblIspitBTeorija";
            this.lblIspitBTeorija.Size = new System.Drawing.Size(38, 16);
            this.lblIspitBTeorija.TabIndex = 2;
            this.lblIspitBTeorija.Text = "Ispit: ";
            this.lblIspitBTeorija.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusC1Teorija2
            // 
            this.lblStatusC1Teorija2.AutoSize = true;
            this.lblStatusC1Teorija2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblStatusC1Teorija2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStatusC1Teorija2.Location = new System.Drawing.Point(60, 29);
            this.lblStatusC1Teorija2.Name = "lblStatusC1Teorija2";
            this.lblStatusC1Teorija2.Size = new System.Drawing.Size(122, 16);
            this.lblStatusC1Teorija2.TabIndex = 1;
            this.lblStatusC1Teorija2.Text = "Predavanja u tijeku";
            // 
            // lblStatusC1Teorija
            // 
            this.lblStatusC1Teorija.AutoSize = true;
            this.lblStatusC1Teorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblStatusC1Teorija.Location = new System.Drawing.Point(6, 29);
            this.lblStatusC1Teorija.Name = "lblStatusC1Teorija";
            this.lblStatusC1Teorija.Size = new System.Drawing.Size(48, 16);
            this.lblStatusC1Teorija.TabIndex = 0;
            this.lblStatusC1Teorija.Text = "Status:";
            // 
            // groupPrvaPomocC1
            // 
            this.groupPrvaPomocC1.Controls.Add(this.lblStatusPomocC12);
            this.groupPrvaPomocC1.Controls.Add(this.btnPomocEvidencija);
            this.groupPrvaPomocC1.Controls.Add(this.lblStatusPomocC1);
            this.groupPrvaPomocC1.Controls.Add(this.btnPomocMaterijali);
            this.groupPrvaPomocC1.Location = new System.Drawing.Point(12, 341);
            this.groupPrvaPomocC1.Name = "groupPrvaPomocC1";
            this.groupPrvaPomocC1.Size = new System.Drawing.Size(760, 90);
            this.groupPrvaPomocC1.TabIndex = 9;
            this.groupPrvaPomocC1.TabStop = false;
            this.groupPrvaPomocC1.Text = "PRVA POMOĆ";
            // 
            // lblStatusPomocC12
            // 
            this.lblStatusPomocC12.AutoSize = true;
            this.lblStatusPomocC12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblStatusPomocC12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatusPomocC12.Location = new System.Drawing.Point(61, 30);
            this.lblStatusPomocC12.Name = "lblStatusPomocC12";
            this.lblStatusPomocC12.Size = new System.Drawing.Size(191, 16);
            this.lblStatusPomocC12.TabIndex = 9;
            this.lblStatusPomocC12.Text = "Početak predavanja - 2.6.2013.";
            // 
            // btnPomocEvidencija
            // 
            this.btnPomocEvidencija.Enabled = false;
            this.btnPomocEvidencija.Location = new System.Drawing.Point(679, 61);
            this.btnPomocEvidencija.Name = "btnPomocEvidencija";
            this.btnPomocEvidencija.Size = new System.Drawing.Size(75, 23);
            this.btnPomocEvidencija.TabIndex = 9;
            this.btnPomocEvidencija.Text = "Evidencija";
            this.btnPomocEvidencija.UseVisualStyleBackColor = true;
            // 
            // lblStatusPomocC1
            // 
            this.lblStatusPomocC1.AutoSize = true;
            this.lblStatusPomocC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblStatusPomocC1.Location = new System.Drawing.Point(7, 30);
            this.lblStatusPomocC1.Name = "lblStatusPomocC1";
            this.lblStatusPomocC1.Size = new System.Drawing.Size(48, 16);
            this.lblStatusPomocC1.TabIndex = 8;
            this.lblStatusPomocC1.Text = "Status:";
            // 
            // btnPomocMaterijali
            // 
            this.btnPomocMaterijali.Enabled = false;
            this.btnPomocMaterijali.Location = new System.Drawing.Point(598, 61);
            this.btnPomocMaterijali.Name = "btnPomocMaterijali";
            this.btnPomocMaterijali.Size = new System.Drawing.Size(75, 23);
            this.btnPomocMaterijali.TabIndex = 8;
            this.btnPomocMaterijali.Text = "Materijali";
            this.btnPomocMaterijali.UseVisualStyleBackColor = true;
            // 
            // groupVoznjaC1
            // 
            this.groupVoznjaC1.Controls.Add(this.btnVoznjaIspit);
            this.groupVoznjaC1.Controls.Add(this.lblStatusVoznjaC12);
            this.groupVoznjaC1.Controls.Add(this.btnVoznjaEvidencija);
            this.groupVoznjaC1.Controls.Add(this.lblStatusVoznjaC1);
            this.groupVoznjaC1.Location = new System.Drawing.Point(12, 460);
            this.groupVoznjaC1.Name = "groupVoznjaC1";
            this.groupVoznjaC1.Size = new System.Drawing.Size(760, 90);
            this.groupVoznjaC1.TabIndex = 10;
            this.groupVoznjaC1.TabStop = false;
            this.groupVoznjaC1.Text = "VOŽNJA";
            // 
            // btnVoznjaIspit
            // 
            this.btnVoznjaIspit.Enabled = false;
            this.btnVoznjaIspit.Location = new System.Drawing.Point(577, 61);
            this.btnVoznjaIspit.Name = "btnVoznjaIspit";
            this.btnVoznjaIspit.Size = new System.Drawing.Size(96, 23);
            this.btnVoznjaIspit.TabIndex = 8;
            this.btnVoznjaIspit.Text = "Rezultat ispita";
            this.btnVoznjaIspit.UseVisualStyleBackColor = true;
            // 
            // lblStatusVoznjaC12
            // 
            this.lblStatusVoznjaC12.AutoSize = true;
            this.lblStatusVoznjaC12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblStatusVoznjaC12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatusVoznjaC12.Location = new System.Drawing.Point(61, 31);
            this.lblStatusVoznjaC12.Name = "lblStatusVoznjaC12";
            this.lblStatusVoznjaC12.Size = new System.Drawing.Size(198, 16);
            this.lblStatusVoznjaC12.TabIndex = 7;
            this.lblStatusVoznjaC12.Text = "Početak predavanja - 12.6.2013.";
            // 
            // btnVoznjaEvidencija
            // 
            this.btnVoznjaEvidencija.Enabled = false;
            this.btnVoznjaEvidencija.Location = new System.Drawing.Point(679, 61);
            this.btnVoznjaEvidencija.Name = "btnVoznjaEvidencija";
            this.btnVoznjaEvidencija.Size = new System.Drawing.Size(75, 23);
            this.btnVoznjaEvidencija.TabIndex = 10;
            this.btnVoznjaEvidencija.Text = "Evidencija";
            this.btnVoznjaEvidencija.UseVisualStyleBackColor = true;
            // 
            // lblStatusVoznjaC1
            // 
            this.lblStatusVoznjaC1.AutoSize = true;
            this.lblStatusVoznjaC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblStatusVoznjaC1.Location = new System.Drawing.Point(7, 31);
            this.lblStatusVoznjaC1.Name = "lblStatusVoznjaC1";
            this.lblStatusVoznjaC1.Size = new System.Drawing.Size(48, 16);
            this.lblStatusVoznjaC1.TabIndex = 6;
            this.lblStatusVoznjaC1.Text = "Status:";
            // 
            // formKatC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupVoznjaC1);
            this.Controls.Add(this.groupPrvaPomocC1);
            this.Controls.Add(this.groupTeorijaC1);
            this.Controls.Add(this.lblNaslovC1);
            this.Controls.Add(this.kalendarObvezaC1);
            this.Controls.Add(this.menuVertikalni);
            this.Name = "formKatC1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoŠkola .NET - Kategorija C1";
            this.menuVertikalni.ResumeLayout(false);
            this.menuVertikalni.PerformLayout();
            this.groupTeorijaC1.ResumeLayout(false);
            this.groupTeorijaC1.PerformLayout();
            this.groupPrvaPomocC1.ResumeLayout(false);
            this.groupPrvaPomocC1.PerformLayout();
            this.groupVoznjaC1.ResumeLayout(false);
            this.groupVoznjaC1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuVertikalni;
        private System.Windows.Forms.ToolStripMenuItem menuBtnHome;
        private System.Windows.Forms.ToolStripMenuItem menuBtnPredmeti;
        private System.Windows.Forms.ToolStripMenuItem menuBtnKatB;
        private System.Windows.Forms.ToolStripMenuItem menuBtnKatC1;
        private System.Windows.Forms.ToolStripMenuItem menuBtnPostavke;
        private System.Windows.Forms.ToolStripMenuItem menuBtnIzlaz;
        private System.Windows.Forms.Label lblNaslovC1;
        private System.Windows.Forms.MonthCalendar kalendarObvezaC1;
        private System.Windows.Forms.GroupBox groupTeorijaC1;
        private System.Windows.Forms.Button btnTeorijaIspit;
        private System.Windows.Forms.Button btnTeorijaEvidencija;
        private System.Windows.Forms.Button btnTeorijaProbno;
        private System.Windows.Forms.Button btnTeorijaMaterijali;
        private System.Windows.Forms.Label lblIspitC1Teorija2;
        private System.Windows.Forms.Label lblIspitBTeorija;
        private System.Windows.Forms.Label lblStatusC1Teorija2;
        private System.Windows.Forms.Label lblStatusC1Teorija;
        private System.Windows.Forms.GroupBox groupPrvaPomocC1;
        private System.Windows.Forms.Label lblStatusPomocC12;
        private System.Windows.Forms.Button btnPomocEvidencija;
        private System.Windows.Forms.Label lblStatusPomocC1;
        private System.Windows.Forms.Button btnPomocMaterijali;
        private System.Windows.Forms.GroupBox groupVoznjaC1;
        private System.Windows.Forms.Button btnVoznjaIspit;
        private System.Windows.Forms.Label lblStatusVoznjaC12;
        private System.Windows.Forms.Button btnVoznjaEvidencija;
        private System.Windows.Forms.Label lblStatusVoznjaC1;
    }
}