namespace Pesquisa_Preco_Termo_Referencia.Forms
{
    partial class FormTermo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTermo));
            this.rptvTermo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptvTermo
            // 
            this.rptvTermo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvTermo.Location = new System.Drawing.Point(0, 0);
            this.rptvTermo.Name = "rptvTermo";
            this.rptvTermo.ServerReport.BearerToken = null;
            this.rptvTermo.Size = new System.Drawing.Size(669, 662);
            this.rptvTermo.TabIndex = 0;
            // 
            // FormTermo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 662);
            this.Controls.Add(this.rptvTermo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTermo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termo de Referência - Núcleo de Compras";
            this.Load += new System.EventHandler(this.FormTermo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvTermo;
    }
}