namespace Pesquisa_Preco_Termo_Referencia.Forms
{
    partial class FormAssuntoTermo
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
            this.richAssunto = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxOrdenador = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionarNovo = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richAssunto
            // 
            this.richAssunto.ForeColor = System.Drawing.Color.DarkCyan;
            this.richAssunto.Location = new System.Drawing.Point(12, 250);
            this.richAssunto.Name = "richAssunto";
            this.richAssunto.Size = new System.Drawing.Size(455, 96);
            this.richAssunto.TabIndex = 0;
            this.richAssunto.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assunto";
            // 
            // cbxOrdenador
            // 
            this.cbxOrdenador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrdenador.FormattingEnabled = true;
            this.cbxOrdenador.Location = new System.Drawing.Point(12, 386);
            this.cbxOrdenador.Name = "cbxOrdenador";
            this.cbxOrdenador.Size = new System.Drawing.Size(425, 24);
            this.cbxOrdenador.TabIndex = 2;
            this.cbxOrdenador.SelectedIndexChanged += new System.EventHandler(this.cbxOrdenador_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(9, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ordenador da Despesa";
            // 
            // btnAdicionarNovo
            // 
            this.btnAdicionarNovo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdicionarNovo.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarNovo.Location = new System.Drawing.Point(443, 386);
            this.btnAdicionarNovo.Name = "btnAdicionarNovo";
            this.btnAdicionarNovo.Size = new System.Drawing.Size(24, 25);
            this.btnAdicionarNovo.TabIndex = 3;
            this.btnAdicionarNovo.Text = "+";
            this.btnAdicionarNovo.UseVisualStyleBackColor = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(12, 442);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(114, 33);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FormAssuntoTermo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 493);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnAdicionarNovo);
            this.Controls.Add(this.cbxOrdenador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richAssunto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAssuntoTermo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termo de Referência - Parâmetros - Núcleo de Compras";
            this.Load += new System.EventHandler(this.FormAssuntoTermo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richAssunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxOrdenador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdicionarNovo;
        private System.Windows.Forms.Button btnEnviar;
    }
}