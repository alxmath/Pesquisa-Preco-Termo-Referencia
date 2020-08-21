namespace Pesquisa_Preco_Termo_Referencia
{
    partial class FormPrincipal
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
            this.richTexto = new System.Windows.Forms.RichTextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnGerarPesquisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTexto
            // 
            this.richTexto.Location = new System.Drawing.Point(12, 12);
            this.richTexto.Name = "richTexto";
            this.richTexto.Size = new System.Drawing.Size(670, 442);
            this.richTexto.TabIndex = 0;
            this.richTexto.Text = "";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(571, 460);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(111, 37);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir Arquivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.ofd.Title = "Abrir Arquivo";
            // 
            // btnGerarPesquisa
            // 
            this.btnGerarPesquisa.Location = new System.Drawing.Point(12, 460);
            this.btnGerarPesquisa.Name = "btnGerarPesquisa";
            this.btnGerarPesquisa.Size = new System.Drawing.Size(111, 37);
            this.btnGerarPesquisa.TabIndex = 2;
            this.btnGerarPesquisa.Text = "Pesquisa";
            this.btnGerarPesquisa.UseVisualStyleBackColor = true;
            this.btnGerarPesquisa.Click += new System.EventHandler(this.btnGerarPesquisa_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 518);
            this.Controls.Add(this.btnGerarPesquisa);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.richTexto);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTexto;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnGerarPesquisa;
    }
}

