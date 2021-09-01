
namespace KlimaUredjaj
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
            this.panelTermometar = new System.Windows.Forms.Panel();
            this.panelIndikator1 = new System.Windows.Forms.Panel();
            this.panelIndikator2 = new System.Windows.Forms.Panel();
            this.textBoxTemperaturaIndikator = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panelTermometar
            // 
            this.panelTermometar.BackColor = System.Drawing.Color.IndianRed;
            this.panelTermometar.Location = new System.Drawing.Point(12, 12);
            this.panelTermometar.Name = "panelTermometar";
            this.panelTermometar.Size = new System.Drawing.Size(35, 420);
            this.panelTermometar.TabIndex = 0;
            this.panelTermometar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTermometar_MouseMove_1);
            // 
            // panelIndikator1
            // 
            this.panelIndikator1.Location = new System.Drawing.Point(253, 86);
            this.panelIndikator1.Name = "panelIndikator1";
            this.panelIndikator1.Size = new System.Drawing.Size(156, 82);
            this.panelIndikator1.TabIndex = 1;
            // 
            // panelIndikator2
            // 
            this.panelIndikator2.Location = new System.Drawing.Point(472, 86);
            this.panelIndikator2.Name = "panelIndikator2";
            this.panelIndikator2.Size = new System.Drawing.Size(156, 82);
            this.panelIndikator2.TabIndex = 2;
            // 
            // textBoxTemperaturaIndikator
            // 
            this.textBoxTemperaturaIndikator.Location = new System.Drawing.Point(86, 395);
            this.textBoxTemperaturaIndikator.Name = "textBoxTemperaturaIndikator";
            this.textBoxTemperaturaIndikator.Size = new System.Drawing.Size(100, 26);
            this.textBoxTemperaturaIndikator.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 476);
            this.Controls.Add(this.textBoxTemperaturaIndikator);
            this.Controls.Add(this.panelIndikator2);
            this.Controls.Add(this.panelIndikator1);
            this.Controls.Add(this.panelTermometar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTermometar;
        private System.Windows.Forms.Panel panelIndikator1;
        private System.Windows.Forms.Panel panelIndikator2;
        private System.Windows.Forms.TextBox textBoxTemperaturaIndikator;
    }
}

