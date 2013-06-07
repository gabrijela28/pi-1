namespace autoskola_2805
{
    partial class Form1
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
            this.txtUpit = new System.Windows.Forms.TextBox();
            this.lblRezUpita = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUpit
            // 
            this.txtUpit.Location = new System.Drawing.Point(13, 23);
            this.txtUpit.Name = "txtUpit";
            this.txtUpit.Size = new System.Drawing.Size(259, 20);
            this.txtUpit.TabIndex = 0;
            // 
            // lblRezUpita
            // 
            this.lblRezUpita.AutoSize = true;
            this.lblRezUpita.Location = new System.Drawing.Point(12, 70);
            this.lblRezUpita.Name = "lblRezUpita";
            this.lblRezUpita.Size = new System.Drawing.Size(35, 13);
            this.lblRezUpita.TabIndex = 1;
            this.lblRezUpita.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblRezUpita);
            this.Controls.Add(this.txtUpit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUpit;
        private System.Windows.Forms.Label lblRezUpita;
    }
}

