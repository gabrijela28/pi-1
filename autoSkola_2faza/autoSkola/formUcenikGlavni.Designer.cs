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
            this.menuVertikalni.SuspendLayout();
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
            this.menuBtnKatB.Size = new System.Drawing.Size(143, 22);
            this.menuBtnKatB.Text = "B kategorija";
            this.menuBtnKatB.Click += new System.EventHandler(this.menuBtnKatB_Click);
            // 
            // menuBtnKatC1
            // 
            this.menuBtnKatC1.Name = "menuBtnKatC1";
            this.menuBtnKatC1.Size = new System.Drawing.Size(143, 22);
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
            // formUcenikGlavni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuVertikalni);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuVertikalni;
            this.Name = "formUcenikGlavni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoŠkola .NET";
            this.Load += new System.EventHandler(this.formUcenikGlavni_Load);
            this.menuVertikalni.ResumeLayout(false);
            this.menuVertikalni.PerformLayout();
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
    }
}