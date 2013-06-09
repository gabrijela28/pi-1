namespace autoSkola
{
    partial class formUciteljGlavni
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
            this.menuVertikalni = new System.Windows.Forms.MenuStrip();
            this.menuBtnPredmeti = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnKatB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnKatC1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnPostavke = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupKategorijaA = new System.Windows.Forms.GroupBox();
            this.btnA = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupKategorijaB = new System.Windows.Forms.GroupBox();
            this.btnB = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sTATISTIKAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVertikalni.SuspendLayout();
            this.groupKategorijaA.SuspendLayout();
            this.groupKategorijaB.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuVertikalni
            // 
            this.menuVertikalni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnPredmeti,
            this.menuBtnPostavke,
            this.sTATISTIKAToolStripMenuItem,
            this.menuBtnIzlaz});
            this.menuVertikalni.Location = new System.Drawing.Point(0, 0);
            this.menuVertikalni.Name = "menuVertikalni";
            this.menuVertikalni.Size = new System.Drawing.Size(784, 24);
            this.menuVertikalni.TabIndex = 1;
            this.menuVertikalni.Text = "menuVertikalni";
            // 
            // menuBtnPredmeti
            // 
            this.menuBtnPredmeti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnKatB,
            this.menuBtnKatC1});
            this.menuBtnPredmeti.Name = "menuBtnPredmeti";
            this.menuBtnPredmeti.Size = new System.Drawing.Size(74, 20);
            this.menuBtnPredmeti.Text = "PREDMETI";
            this.menuBtnPredmeti.Click += new System.EventHandler(this.menuBtnPredmeti_Click);
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
            // menuBtnIzlaz
            // 
            this.menuBtnIzlaz.Checked = true;
            this.menuBtnIzlaz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuBtnIzlaz.Name = "menuBtnIzlaz";
            this.menuBtnIzlaz.Size = new System.Drawing.Size(50, 20);
            this.menuBtnIzlaz.Text = "IZLAZ";
            this.menuBtnIzlaz.Click += new System.EventHandler(this.menuBtnIzlaz_Click);
            // 
            // groupKategorijaA
            // 
            this.groupKategorijaA.Controls.Add(this.btnA);
            this.groupKategorijaA.Controls.Add(this.label6);
            this.groupKategorijaA.Controls.Add(this.label5);
            this.groupKategorijaA.Controls.Add(this.label3);
            this.groupKategorijaA.Controls.Add(this.label1);
            this.groupKategorijaA.Location = new System.Drawing.Point(12, 27);
            this.groupKategorijaA.Name = "groupKategorijaA";
            this.groupKategorijaA.Size = new System.Drawing.Size(760, 84);
            this.groupKategorijaA.TabIndex = 2;
            this.groupKategorijaA.TabStop = false;
            this.groupKategorijaA.Text = "A kategorija";
            this.groupKategorijaA.Enter += new System.EventHandler(this.groupKategorijaA_Enter);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(679, 54);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 4;
            this.btnA.Text = "Više";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "1";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Broj grupa: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "7";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj polaznika: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupKategorijaB
            // 
            this.groupKategorijaB.Controls.Add(this.btnB);
            this.groupKategorijaB.Controls.Add(this.label7);
            this.groupKategorijaB.Controls.Add(this.label8);
            this.groupKategorijaB.Controls.Add(this.label2);
            this.groupKategorijaB.Controls.Add(this.label4);
            this.groupKategorijaB.Location = new System.Drawing.Point(12, 117);
            this.groupKategorijaB.Name = "groupKategorijaB";
            this.groupKategorijaB.Size = new System.Drawing.Size(760, 87);
            this.groupKategorijaB.TabIndex = 3;
            this.groupKategorijaB.TabStop = false;
            this.groupKategorijaB.Text = "B kategorija";
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(679, 58);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(75, 23);
            this.btnB.TabIndex = 6;
            this.btnB.Text = "Više";
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Broj grupa: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "32";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Broj polaznika: ";
            // 
            // sTATISTIKAToolStripMenuItem
            // 
            this.sTATISTIKAToolStripMenuItem.Name = "sTATISTIKAToolStripMenuItem";
            this.sTATISTIKAToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.sTATISTIKAToolStripMenuItem.Text = "STATISTIKA";
            this.sTATISTIKAToolStripMenuItem.Click += new System.EventHandler(this.sTATISTIKAToolStripMenuItem_Click);
            // 
            // formUciteljGlavni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupKategorijaB);
            this.Controls.Add(this.groupKategorijaA);
            this.Controls.Add(this.menuVertikalni);
            this.Name = "formUciteljGlavni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoŠkola.NET";
            this.menuVertikalni.ResumeLayout(false);
            this.menuVertikalni.PerformLayout();
            this.groupKategorijaA.ResumeLayout(false);
            this.groupKategorijaA.PerformLayout();
            this.groupKategorijaB.ResumeLayout(false);
            this.groupKategorijaB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuVertikalni;
        private System.Windows.Forms.ToolStripMenuItem menuBtnPredmeti;
        private System.Windows.Forms.ToolStripMenuItem menuBtnKatB;
        private System.Windows.Forms.ToolStripMenuItem menuBtnKatC1;
        private System.Windows.Forms.ToolStripMenuItem menuBtnPostavke;
        private System.Windows.Forms.ToolStripMenuItem menuBtnIzlaz;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupKategorijaA;
        private System.Windows.Forms.GroupBox groupKategorijaB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.ToolStripMenuItem sTATISTIKAToolStripMenuItem;
    }
}

