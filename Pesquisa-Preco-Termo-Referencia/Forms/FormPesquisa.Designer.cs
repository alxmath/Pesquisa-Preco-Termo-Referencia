namespace Pesquisa_Preco_Termo_Referencia.Forms
{
    partial class FormPesquisa
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
            this.rptv1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptv1
            // 
            this.rptv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptv1.LocalReport.ReportPath = "";
            this.rptv1.Location = new System.Drawing.Point(0, 0);
            this.rptv1.Name = "rptv1";
            this.rptv1.ServerReport.BearerToken = null;
            this.rptv1.Size = new System.Drawing.Size(1039, 790);
            this.rptv1.TabIndex = 0;
            // 
            // FormPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 790);
            this.Controls.Add(this.rptv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Preço - Núcleo de Compras";
            this.Load += new System.EventHandler(this.FormPesquisa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptv1;
    }
}