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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.richTexto = new System.Windows.Forms.RichTextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnGerarPesquisa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxLoteItem = new System.Windows.Forms.ComboBox();
            this.radioConvite = new System.Windows.Forms.RadioButton();
            this.radioDispensa = new System.Windows.Forms.RadioButton();
            this.radioAta = new System.Windows.Forms.RadioButton();
            this.radioPregao = new System.Windows.Forms.RadioButton();
            this.btnTermo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtProcessoPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipPrincipal = new System.Windows.Forms.ToolTip(this.components);
            this.linkSobre = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTexto
            // 
            this.richTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTexto.ForeColor = System.Drawing.Color.DarkCyan;
            this.richTexto.Location = new System.Drawing.Point(12, 218);
            this.richTexto.Name = "richTexto";
            this.richTexto.ReadOnly = true;
            this.richTexto.Size = new System.Drawing.Size(563, 340);
            this.richTexto.TabIndex = 0;
            this.richTexto.Text = "";
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.White;
            this.btnAbrir.Location = new System.Drawing.Point(12, 161);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(187, 37);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir Arquivo de Texto ...";
            this.toolTipPrincipal.SetToolTip(this.btnAbrir, "\r\nClique neste botão para importar o aquivo de\r\ntexto com os dados do pedido de c" +
        "ompras.");
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.ofd.Title = "Abrir Arquivo";
            // 
            // btnGerarPesquisa
            // 
            this.btnGerarPesquisa.BackColor = System.Drawing.Color.Green;
            this.btnGerarPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarPesquisa.ForeColor = System.Drawing.Color.White;
            this.btnGerarPesquisa.Location = new System.Drawing.Point(425, 593);
            this.btnGerarPesquisa.Name = "btnGerarPesquisa";
            this.btnGerarPesquisa.Size = new System.Drawing.Size(150, 37);
            this.btnGerarPesquisa.TabIndex = 5;
            this.btnGerarPesquisa.Text = "Gerar Pesquisa";
            this.toolTipPrincipal.SetToolTip(this.btnGerarPesquisa, "\r\nGera a pesquisa de preços.");
            this.btnGerarPesquisa.UseVisualStyleBackColor = false;
            this.btnGerarPesquisa.Click += new System.EventHandler(this.btnGerarPesquisa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxLoteItem);
            this.groupBox1.Controls.Add(this.radioConvite);
            this.groupBox1.Controls.Add(this.radioDispensa);
            this.groupBox1.Controls.Add(this.radioAta);
            this.groupBox1.Controls.Add(this.radioPregao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Licitação";
            // 
            // cbxLoteItem
            // 
            this.cbxLoteItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoteItem.FormattingEnabled = true;
            this.cbxLoteItem.Items.AddRange(new object[] {
            "Por item",
            "Por lote"});
            this.cbxLoteItem.Location = new System.Drawing.Point(109, 40);
            this.cbxLoteItem.Name = "cbxLoteItem";
            this.cbxLoteItem.Size = new System.Drawing.Size(121, 24);
            this.cbxLoteItem.Sorted = true;
            this.cbxLoteItem.TabIndex = 4;
            this.cbxLoteItem.Visible = false;
            // 
            // radioConvite
            // 
            this.radioConvite.AutoSize = true;
            this.radioConvite.Location = new System.Drawing.Point(30, 67);
            this.radioConvite.Name = "radioConvite";
            this.radioConvite.Size = new System.Drawing.Size(73, 21);
            this.radioConvite.TabIndex = 3;
            this.radioConvite.TabStop = true;
            this.radioConvite.Text = "Convite";
            this.radioConvite.UseVisualStyleBackColor = true;
            // 
            // radioDispensa
            // 
            this.radioDispensa.AutoSize = true;
            this.radioDispensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDispensa.Location = new System.Drawing.Point(316, 67);
            this.radioDispensa.Name = "radioDispensa";
            this.radioDispensa.Size = new System.Drawing.Size(85, 21);
            this.radioDispensa.TabIndex = 2;
            this.radioDispensa.TabStop = true;
            this.radioDispensa.Text = "Dispensa";
            this.radioDispensa.UseVisualStyleBackColor = true;
            // 
            // radioAta
            // 
            this.radioAta.AutoSize = true;
            this.radioAta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAta.Location = new System.Drawing.Point(316, 40);
            this.radioAta.Name = "radioAta";
            this.radioAta.Size = new System.Drawing.Size(47, 21);
            this.radioAta.TabIndex = 1;
            this.radioAta.TabStop = true;
            this.radioAta.Text = "Ata";
            this.radioAta.UseVisualStyleBackColor = true;
            // 
            // radioPregao
            // 
            this.radioPregao.AutoSize = true;
            this.radioPregao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPregao.Location = new System.Drawing.Point(31, 40);
            this.radioPregao.Name = "radioPregao";
            this.radioPregao.Size = new System.Drawing.Size(72, 21);
            this.radioPregao.TabIndex = 0;
            this.radioPregao.TabStop = true;
            this.radioPregao.Text = "Pregão";
            this.radioPregao.UseVisualStyleBackColor = true;
            this.radioPregao.CheckedChanged += new System.EventHandler(this.radioPregao_CheckedChanged);
            // 
            // btnTermo
            // 
            this.btnTermo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTermo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermo.ForeColor = System.Drawing.Color.White;
            this.btnTermo.Location = new System.Drawing.Point(269, 593);
            this.btnTermo.Name = "btnTermo";
            this.btnTermo.Size = new System.Drawing.Size(150, 37);
            this.btnTermo.TabIndex = 4;
            this.btnTermo.Text = "Gerar Termo de Ref.";
            this.toolTipPrincipal.SetToolTip(this.btnTermo, "\r\nGera o termo de referência.");
            this.btnTermo.UseVisualStyleBackColor = false;
            this.btnTermo.Click += new System.EventHandler(this.btnTermo_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(12, 593);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 37);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.toolTipPrincipal.SetToolTip(this.btnSair, "\r\nFecha o programa.");
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtProcessoPedido
            // 
            this.txtProcessoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessoPedido.Location = new System.Drawing.Point(344, 168);
            this.txtProcessoPedido.Name = "txtProcessoPedido";
            this.txtProcessoPedido.Size = new System.Drawing.Size(231, 23);
            this.txtProcessoPedido.TabIndex = 2;
            this.toolTipPrincipal.SetToolTip(this.txtProcessoPedido, "\r\nCampo opcional.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(219, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Processo/Pedido:";
            // 
            // toolTipPrincipal
            // 
            this.toolTipPrincipal.AutoPopDelay = 5000;
            this.toolTipPrincipal.InitialDelay = 500;
            this.toolTipPrincipal.IsBalloon = true;
            this.toolTipPrincipal.ReshowDelay = 100;
            this.toolTipPrincipal.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipPrincipal.ToolTipTitle = "Ajuda Rápida";
            // 
            // linkSobre
            // 
            this.linkSobre.AutoSize = true;
            this.linkSobre.Location = new System.Drawing.Point(540, 18);
            this.linkSobre.Name = "linkSobre";
            this.linkSobre.Size = new System.Drawing.Size(35, 13);
            this.linkSobre.TabIndex = 8;
            this.linkSobre.TabStop = true;
            this.linkSobre.Text = "Sobre";
            this.linkSobre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSobre_LinkClicked);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 644);
            this.Controls.Add(this.linkSobre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProcessoPedido);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTermo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGerarPesquisa);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.richTexto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Preço e Termo de Referência - Núcleo de Compras";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTexto;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnGerarPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioAta;
        private System.Windows.Forms.RadioButton radioPregao;
        private System.Windows.Forms.Button btnTermo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.RadioButton radioDispensa;
        private System.Windows.Forms.TextBox txtProcessoPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipPrincipal;
        private System.Windows.Forms.ComboBox cbxLoteItem;
        private System.Windows.Forms.RadioButton radioConvite;
        private System.Windows.Forms.LinkLabel linkSobre;
    }
}

