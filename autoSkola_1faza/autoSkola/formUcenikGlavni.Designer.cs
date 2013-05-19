namespace autoSkola
{
    partial class formUcenikGlavni
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
            this.groupKatB = new System.Windows.Forms.GroupBox();
            this.lblVaznoKatB = new System.Windows.Forms.Label();
            this.btnViseB = new System.Windows.Forms.Button();
            this.lblStatusB2 = new System.Windows.Forms.Label();
            this.lblStatusB = new System.Windows.Forms.Label();
            this.groupKatC1 = new System.Windows.Forms.GroupBox();
            this.lblVaznoKatC12 = new System.Windows.Forms.Label();
            this.lblVaznoKatC1 = new System.Windows.Forms.Label();
            this.lblStatusC12 = new System.Windows.Forms.Label();
            this.btnViseC1 = new System.Windows.Forms.Button();
            this.lblStatusC1 = new System.Windows.Forms.Label();
            this.menuVertikalni.SuspendLayout();
            this.groupKatB.SuspendLayout();
            this.groupKatC1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuVertikalni
            // 
            this.menuVertikalni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnPredmeti,
            this.menuBtnPostavke,
            this.menuBtnIzlaz});
            this.menuVertikalni.Location = new System.Drawing.Point(0, 0);
            this.menuVertikalni.Name = "menuVertikalni";
            this.menuVertikalni.Size = new System.Drawing.Size(784, 24);
            this.menuVertikalni.TabIndex = 0;
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
            // groupKatB
            // 
            this.groupKatB.Controls.Add(this.lblVaznoKatB);
            this.groupKatB.Controls.Add(this.btnViseB);
            this.groupKatB.Controls.Add(this.lblStatusB2);
            this.groupKatB.Controls.Add(this.lblStatusB);
            this.groupKatB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupKatB.Location = new System.Drawing.Point(12, 65);
            this.groupKatB.Name = "groupKatB";
            this.groupKatB.Size = new System.Drawing.Size(760, 73);
            this.groupKatB.TabIndex = 1;
            this.groupKatB.TabStop = false;
            this.groupKatB.Text = "B kategorija";
            this.groupKatB.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblVaznoKatB
            // 
            this.lblVaznoKatB.AutoSize = true;
            this.lblVaznoKatB.Location = new System.Drawing.Point(7, 51);
            this.lblVaznoKatB.Name = "lblVaznoKatB";
            this.lblVaznoKatB.Size = new System.Drawing.Size(49, 16);
            this.lblVaznoKatB.TabIndex = 3;
            this.lblVaznoKatB.Text = "Važno:";
            // 
            // btnViseB
            // 
            this.btnViseB.Location = new System.Drawing.Point(679, 44);
            this.btnViseB.Name = "btnViseB";
            this.btnViseB.Size = new System.Drawing.Size(75, 23);
            this.btnViseB.TabIndex = 2;
            this.btnViseB.Text = "Više";
            this.btnViseB.UseVisualStyleBackColor = true;
            this.btnViseB.Click += new System.EventHandler(this.btnViseB_Click);
            // 
            // lblStatusB2
            // 
            this.lblStatusB2.AutoSize = true;
            this.lblStatusB2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStatusB2.Location = new System.Drawing.Point(61, 28);
            this.lblStatusB2.Name = "lblStatusB2";
            this.lblStatusB2.Size = new System.Drawing.Size(65, 16);
            this.lblStatusB2.TabIndex = 1;
            this.lblStatusB2.Text = "Položeno";
            // 
            // lblStatusB
            // 
            this.lblStatusB.AutoSize = true;
            this.lblStatusB.Location = new System.Drawing.Point(7, 28);
            this.lblStatusB.Name = "lblStatusB";
            this.lblStatusB.Size = new System.Drawing.Size(48, 16);
            this.lblStatusB.TabIndex = 0;
            this.lblStatusB.Text = "Status:";
            // 
            // groupKatC1
            // 
            this.groupKatC1.Controls.Add(this.lblVaznoKatC12);
            this.groupKatC1.Controls.Add(this.lblVaznoKatC1);
            this.groupKatC1.Controls.Add(this.lblStatusC12);
            this.groupKatC1.Controls.Add(this.btnViseC1);
            this.groupKatC1.Controls.Add(this.lblStatusC1);
            this.groupKatC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupKatC1.Location = new System.Drawing.Point(12, 158);
            this.groupKatC1.Name = "groupKatC1";
            this.groupKatC1.Size = new System.Drawing.Size(760, 73);
            this.groupKatC1.TabIndex = 2;
            this.groupKatC1.TabStop = false;
            this.groupKatC1.Text = "C1 kategorija";
            // 
            // lblVaznoKatC12
            // 
            this.lblVaznoKatC12.AutoSize = true;
            this.lblVaznoKatC12.Location = new System.Drawing.Point(61, 51);
            this.lblVaznoKatC12.Name = "lblVaznoKatC12";
            this.lblVaznoKatC12.Size = new System.Drawing.Size(137, 16);
            this.lblVaznoKatC12.TabIndex = 6;
            this.lblVaznoKatC12.Text = "Dodani novi materijali";
            // 
            // lblVaznoKatC1
            // 
            this.lblVaznoKatC1.AutoSize = true;
            this.lblVaznoKatC1.Location = new System.Drawing.Point(7, 51);
            this.lblVaznoKatC1.Name = "lblVaznoKatC1";
            this.lblVaznoKatC1.Size = new System.Drawing.Size(49, 16);
            this.lblVaznoKatC1.TabIndex = 4;
            this.lblVaznoKatC1.Text = "Važno:";
            // 
            // lblStatusC12
            // 
            this.lblStatusC12.AutoSize = true;
            this.lblStatusC12.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStatusC12.Location = new System.Drawing.Point(61, 29);
            this.lblStatusC12.Name = "lblStatusC12";
            this.lblStatusC12.Size = new System.Drawing.Size(122, 16);
            this.lblStatusC12.TabIndex = 4;
            this.lblStatusC12.Text = "Predavanja u tijeku";
            // 
            // btnViseC1
            // 
            this.btnViseC1.Location = new System.Drawing.Point(679, 44);
            this.btnViseC1.Name = "btnViseC1";
            this.btnViseC1.Size = new System.Drawing.Size(75, 23);
            this.btnViseC1.TabIndex = 5;
            this.btnViseC1.Text = "Više";
            this.btnViseC1.UseVisualStyleBackColor = true;
            this.btnViseC1.Click += new System.EventHandler(this.btnViseC1_Click);
            // 
            // lblStatusC1
            // 
            this.lblStatusC1.AutoSize = true;
            this.lblStatusC1.Location = new System.Drawing.Point(7, 29);
            this.lblStatusC1.Name = "lblStatusC1";
            this.lblStatusC1.Size = new System.Drawing.Size(48, 16);
            this.lblStatusC1.TabIndex = 3;
            this.lblStatusC1.Text = "Status:";
            // 
            // formUcenikGlavni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupKatC1);
            this.Controls.Add(this.groupKatB);
            this.Controls.Add(this.menuVertikalni);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuVertikalni;
            this.Name = "formUcenikGlavni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoŠkola .NET";
            this.menuVertikalni.ResumeLayout(false);
            this.menuVertikalni.PerformLayout();
            this.groupKatB.ResumeLayout(false);
            this.groupKatB.PerformLayout();
            this.groupKatC1.ResumeLayout(false);
            this.groupKatC1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuVertikalni;
        private System.Windows.Forms.ToolStripMenuItem menuBtnIzlaz;
        private System.Windows.Forms.ToolStripMenuItem menuBtnPostavke;
        private System.Windows.Forms.ToolStripMenuItem menuBtnPredmeti;
        private System.Windows.Forms.ToolStripMenuItem menuBtnKatB;
        private System.Windows.Forms.ToolStripMenuItem menuBtnKatC1;
        private System.Windows.Forms.GroupBox groupKatB;
        private System.Windows.Forms.GroupBox groupKatC1;
        private System.Windows.Forms.Button btnViseB;
        private System.Windows.Forms.Label lblStatusB2;
        private System.Windows.Forms.Label lblStatusB;
        private System.Windows.Forms.Label lblStatusC12;
        private System.Windows.Forms.Button btnViseC1;
        private System.Windows.Forms.Label lblStatusC1;
        private System.Windows.Forms.Label lblVaznoKatB;
        private System.Windows.Forms.Label lblVaznoKatC12;
        private System.Windows.Forms.Label lblVaznoKatC1;
    }
}