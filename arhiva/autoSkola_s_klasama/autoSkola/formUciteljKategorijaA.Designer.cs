namespace autoSkola
{
    partial class formUciteljKategorijaA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUciteljKategorijaA));
            this.kalendarObvezaB = new System.Windows.Forms.MonthCalendar();
            this.lblNaslovB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEvidencija = new System.Windows.Forms.Button();
            this.btnRok = new System.Windows.Forms.Button();
            this.btnNMaterijal = new System.Windows.Forms.Button();
            this.btnNCjelina = new System.Windows.Forms.Button();
            this.menuVertikalni = new System.Windows.Forms.MenuStrip();
            this.menuBtnHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnPredmeti = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnKatB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnKatC1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnPostavke = new System.Windows.Forms.ToolStripMenuItem();
            this.sTATISTIKAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.menuVertikalni.SuspendLayout();
            this.SuspendLayout();
            // 
            // kalendarObvezaB
            // 
            this.kalendarObvezaB.BoldedDates = new System.DateTime[] {
        new System.DateTime(2013, 5, 1, 0, 0, 0, 0)};
            this.kalendarObvezaB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.kalendarObvezaB.Location = new System.Drawing.Point(573, 35);
            this.kalendarObvezaB.Name = "kalendarObvezaB";
            this.kalendarObvezaB.TabIndex = 5;
            this.kalendarObvezaB.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.kalendarObvezaB_DateChanged);
            // 
            // lblNaslovB
            // 
            this.lblNaslovB.AutoSize = true;
            this.lblNaslovB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslovB.Location = new System.Drawing.Point(19, 35);
            this.lblNaslovB.Name = "lblNaslovB";
            this.lblNaslovB.Size = new System.Drawing.Size(173, 31);
            this.lblNaslovB.TabIndex = 6;
            this.lblNaslovB.Text = "Kategorija A";
            this.lblNaslovB.Click += new System.EventHandler(this.lblNaslovB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEvidencija);
            this.groupBox1.Controls.Add(this.btnRok);
            this.groupBox1.Location = new System.Drawing.Point(12, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 130);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupa 1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnEvidencija
            // 
            this.btnEvidencija.Location = new System.Drawing.Point(104, 19);
            this.btnEvidencija.Name = "btnEvidencija";
            this.btnEvidencija.Size = new System.Drawing.Size(75, 23);
            this.btnEvidencija.TabIndex = 1;
            this.btnEvidencija.Text = "Evidencija";
            this.btnEvidencija.UseVisualStyleBackColor = true;
            this.btnEvidencija.Click += new System.EventHandler(this.btnEvidencija_Click);
            // 
            // btnRok
            // 
            this.btnRok.Location = new System.Drawing.Point(7, 20);
            this.btnRok.Name = "btnRok";
            this.btnRok.Size = new System.Drawing.Size(75, 23);
            this.btnRok.TabIndex = 0;
            this.btnRok.Text = "Novi rok";
            this.btnRok.UseVisualStyleBackColor = true;
            this.btnRok.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNMaterijal
            // 
            this.btnNMaterijal.Location = new System.Drawing.Point(55, 84);
            this.btnNMaterijal.Name = "btnNMaterijal";
            this.btnNMaterijal.Size = new System.Drawing.Size(85, 23);
            this.btnNMaterijal.TabIndex = 8;
            this.btnNMaterijal.Text = "Dodaj materijal";
            this.btnNMaterijal.UseVisualStyleBackColor = true;
            this.btnNMaterijal.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnNCjelina
            // 
            this.btnNCjelina.Location = new System.Drawing.Point(55, 113);
            this.btnNCjelina.Name = "btnNCjelina";
            this.btnNCjelina.Size = new System.Drawing.Size(85, 23);
            this.btnNCjelina.TabIndex = 9;
            this.btnNCjelina.Text = "Dodaj cjelinu";
            this.btnNCjelina.UseVisualStyleBackColor = true;
            this.btnNCjelina.Click += new System.EventHandler(this.btnNCjelina_Click);
            // 
            // menuVertikalni
            // 
            this.menuVertikalni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnHome,
            this.menuBtnPredmeti,
            this.menuBtnPostavke,
            this.sTATISTIKAToolStripMenuItem,
            this.menuBtnIzlaz});
            this.menuVertikalni.Location = new System.Drawing.Point(0, 0);
            this.menuVertikalni.Name = "menuVertikalni";
            this.menuVertikalni.Size = new System.Drawing.Size(784, 24);
            this.menuVertikalni.TabIndex = 10;
            this.menuVertikalni.Text = "menuVertikalni";
            this.menuVertikalni.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuVertikalni_ItemClicked);
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
            this.menuBtnKatB.Size = new System.Drawing.Size(137, 22);
            this.menuBtnKatB.Text = "A kategorija";
            this.menuBtnKatB.Click += new System.EventHandler(this.menuBtnKatB_Click);
            // 
            // menuBtnKatC1
            // 
            this.menuBtnKatC1.Name = "menuBtnKatC1";
            this.menuBtnKatC1.Size = new System.Drawing.Size(137, 22);
            this.menuBtnKatC1.Text = "B kategorija";
            this.menuBtnKatC1.Click += new System.EventHandler(this.menuBtnKatC1_Click);
            // 
            // menuBtnPostavke
            // 
            this.menuBtnPostavke.Name = "menuBtnPostavke";
            this.menuBtnPostavke.Size = new System.Drawing.Size(76, 20);
            this.menuBtnPostavke.Text = "POSTAVKE";
            this.menuBtnPostavke.Click += new System.EventHandler(this.menuBtnPostavke_Click);
            // 
            // sTATISTIKAToolStripMenuItem
            // 
            this.sTATISTIKAToolStripMenuItem.Name = "sTATISTIKAToolStripMenuItem";
            this.sTATISTIKAToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.sTATISTIKAToolStripMenuItem.Text = "STATISTIKA";
            this.sTATISTIKAToolStripMenuItem.Click += new System.EventHandler(this.sTATISTIKAToolStripMenuItem_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dodaj pitanja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // formUciteljKategorijaA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuVertikalni);
            this.Controls.Add(this.btnNCjelina);
            this.Controls.Add(this.btnNMaterijal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNaslovB);
            this.Controls.Add(this.kalendarObvezaB);
            this.Name = "formUciteljKategorijaA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoŠkola.NET - Kategorija A";
            this.Load += new System.EventHandler(this.formUciteljKategorijaA_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuVertikalni.ResumeLayout(false);
            this.menuVertikalni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar kalendarObvezaB;
        private System.Windows.Forms.Label lblNaslovB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRok;
        private System.Windows.Forms.Button btnEvidencija;
        private System.Windows.Forms.Button btnNMaterijal;
        private System.Windows.Forms.Button btnNCjelina;
        private System.Windows.Forms.MenuStrip menuVertikalni;
        private System.Windows.Forms.ToolStripMenuItem menuBtnHome;
        private System.Windows.Forms.ToolStripMenuItem menuBtnPredmeti;
        private System.Windows.Forms.ToolStripMenuItem menuBtnKatB;
        private System.Windows.Forms.ToolStripMenuItem menuBtnKatC1;
        private System.Windows.Forms.ToolStripMenuItem menuBtnPostavke;
        private System.Windows.Forms.ToolStripMenuItem menuBtnIzlaz;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem sTATISTIKAToolStripMenuItem;
    }
}