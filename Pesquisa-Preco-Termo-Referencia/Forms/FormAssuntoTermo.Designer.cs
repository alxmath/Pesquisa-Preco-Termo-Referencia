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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkJun = new System.Windows.Forms.CheckBox();
            this.checkNov = new System.Windows.Forms.CheckBox();
            this.checkDez = new System.Windows.Forms.CheckBox();
            this.checkMai = new System.Windows.Forms.CheckBox();
            this.checkOut = new System.Windows.Forms.CheckBox();
            this.checkAbr = new System.Windows.Forms.CheckBox();
            this.checkSet = new System.Windows.Forms.CheckBox();
            this.checkAgo = new System.Windows.Forms.CheckBox();
            this.checkMar = new System.Windows.Forms.CheckBox();
            this.checkJul = new System.Windows.Forms.CheckBox();
            this.checkFev = new System.Windows.Forms.CheckBox();
            this.checkJan = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioRP = new System.Windows.Forms.RadioButton();
            this.radioCV = new System.Windows.Forms.RadioButton();
            this.radioIN = new System.Windows.Forms.RadioButton();
            this.radioDL = new System.Windows.Forms.RadioButton();
            this.radioPE = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.radioAquisicao = new System.Windows.Forms.RadioButton();
            this.radioServico = new System.Windows.Forms.RadioButton();
            this.checkMemo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richAssunto
            // 
            this.richAssunto.ForeColor = System.Drawing.Color.DarkCyan;
            this.richAssunto.Location = new System.Drawing.Point(12, 328);
            this.richAssunto.Name = "richAssunto";
            this.richAssunto.Size = new System.Drawing.Size(460, 76);
            this.richAssunto.TabIndex = 1;
            this.richAssunto.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assunto";
            // 
            // cbxOrdenador
            // 
            this.cbxOrdenador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrdenador.FormattingEnabled = true;
            this.cbxOrdenador.Location = new System.Drawing.Point(12, 438);
            this.cbxOrdenador.Name = "cbxOrdenador";
            this.cbxOrdenador.Size = new System.Drawing.Size(425, 24);
            this.cbxOrdenador.TabIndex = 2;
            this.cbxOrdenador.SelectedIndexChanged += new System.EventHandler(this.cbxOrdenador_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(9, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ordenador da Despesa";
            // 
            // btnAdicionarNovo
            // 
            this.btnAdicionarNovo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdicionarNovo.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarNovo.Location = new System.Drawing.Point(448, 437);
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
            this.btnEnviar.Location = new System.Drawing.Point(12, 478);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(114, 33);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtMemo);
            this.groupBox1.Controls.Add(this.radioAquisicao);
            this.groupBox1.Controls.Add(this.radioServico);
            this.groupBox1.Controls.Add(this.checkMemo);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkJun);
            this.groupBox3.Controls.Add(this.checkNov);
            this.groupBox3.Controls.Add(this.checkDez);
            this.groupBox3.Controls.Add(this.checkMai);
            this.groupBox3.Controls.Add(this.checkOut);
            this.groupBox3.Controls.Add(this.checkAbr);
            this.groupBox3.Controls.Add(this.checkSet);
            this.groupBox3.Controls.Add(this.checkAgo);
            this.groupBox3.Controls.Add(this.checkMar);
            this.groupBox3.Controls.Add(this.checkJul);
            this.groupBox3.Controls.Add(this.checkFev);
            this.groupBox3.Controls.Add(this.checkJan);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox3.Location = new System.Drawing.Point(16, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 88);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Período";
            // 
            // checkJun
            // 
            this.checkJun.AutoSize = true;
            this.checkJun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkJun.Location = new System.Drawing.Point(361, 28);
            this.checkJun.Name = "checkJun";
            this.checkJun.Size = new System.Drawing.Size(43, 17);
            this.checkJun.TabIndex = 5;
            this.checkJun.Tag = "junho";
            this.checkJun.Text = "Jun";
            this.checkJun.UseVisualStyleBackColor = true;
            this.checkJun.Click += new System.EventHandler(this.CheckMes_CheckedChanged);
            // 
            // checkNov
            // 
            this.checkNov.AutoSize = true;
            this.checkNov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNov.Location = new System.Drawing.Point(285, 55);
            this.checkNov.Name = "checkNov";
            this.checkNov.Size = new System.Drawing.Size(46, 17);
            this.checkNov.TabIndex = 10;
            this.checkNov.Tag = "novembro";
            this.checkNov.Text = "Nov";
            this.checkNov.UseVisualStyleBackColor = true;
            this.checkNov.Click += new System.EventHandler(this.CheckMes_CheckedChanged);
            // 
            // checkDez
            // 
            this.checkDez.AutoSize = true;
            this.checkDez.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDez.Location = new System.Drawing.Point(360, 55);
            this.checkDez.Name = "checkDez";
            this.checkDez.Size = new System.Drawing.Size(45, 17);
            this.checkDez.TabIndex = 11;
            this.checkDez.Tag = "dezembro";
            this.checkDez.Text = "Dez";
            this.checkDez.UseVisualStyleBackColor = true;
            this.checkDez.Click += new System.EventHandler(this.CheckMes_CheckedChanged);
            // 
            // checkMai
            // 
            this.checkMai.AutoSize = true;
            this.checkMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMai.Location = new System.Drawing.Point(285, 28);
            this.checkMai.Name = "checkMai";
            this.checkMai.Size = new System.Drawing.Size(43, 17);
            this.checkMai.TabIndex = 4;
            this.checkMai.Tag = "maio";
            this.checkMai.Text = "Mai";
            this.checkMai.UseVisualStyleBackColor = true;
            this.checkMai.Click += new System.EventHandler(this.CheckMes_CheckedChanged);
            // 
            // checkOut
            // 
            this.checkOut.AutoSize = true;
            this.checkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut.Location = new System.Drawing.Point(227, 55);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(43, 17);
            this.checkOut.TabIndex = 9;
            this.checkOut.Tag = "outubro";
            this.checkOut.Text = "Out";
            this.checkOut.UseVisualStyleBackColor = true;
            this.checkOut.Click += new System.EventHandler(this.CheckMes_CheckedChanged);
            // 
            // checkAbr
            // 
            this.checkAbr.AutoSize = true;
            this.checkAbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAbr.Location = new System.Drawing.Point(227, 28);
            this.checkAbr.Name = "checkAbr";
            this.checkAbr.Size = new System.Drawing.Size(42, 17);
            this.checkAbr.TabIndex = 3;
            this.checkAbr.Tag = "abril";
            this.checkAbr.Text = "Abr";
            this.checkAbr.UseVisualStyleBackColor = true;
            this.checkAbr.Click += new System.EventHandler(this.CheckMes_CheckedChanged);
            // 
            // checkSet
            // 
            this.checkSet.AutoSize = true;
            this.checkSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSet.Location = new System.Drawing.Point(160, 55);
            this.checkSet.Name = "checkSet";
            this.checkSet.Size = new System.Drawing.Size(42, 17);
            this.checkSet.TabIndex = 8;
            this.checkSet.Tag = "setembro";
            this.checkSet.Text = "Set";
            this.checkSet.UseVisualStyleBackColor = true;
            this.checkSet.Click += new System.EventHandler(this.CheckMes_CheckedChanged);
            // 
            // checkAgo
            // 
            this.checkAgo.AutoSize = true;
            this.checkAgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAgo.Location = new System.Drawing.Point(91, 55);
            this.checkAgo.Name = "checkAgo";
            this.checkAgo.Size = new System.Drawing.Size(45, 17);
            this.checkAgo.TabIndex = 7;
            this.checkAgo.Tag = "agosto";
            this.checkAgo.Text = "Ago";
            this.checkAgo.UseVisualStyleBackColor = true;
            this.checkAgo.Click += new System.EventHandler(this.CheckMes_CheckedChanged);
            // 
            // checkMar
            // 
            this.checkMar.AutoSize = true;
            this.checkMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMar.Location = new System.Drawing.Point(160, 28);
            this.checkMar.Name = "checkMar";
            this.checkMar.Size = new System.Drawing.Size(44, 17);
            this.checkMar.TabIndex = 2;
            this.checkMar.Tag = "março";
            this.checkMar.Text = "Mar";
            this.checkMar.UseVisualStyleBackColor = true;
            this.checkMar.Click += new System.EventHandler(this.CheckMes_CheckedChanged);
            // 
            // checkJul
            // 
            this.checkJul.AutoSize = true;
            this.checkJul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkJul.Location = new System.Drawing.Point(28, 55);
            this.checkJul.Name = "checkJul";
            this.checkJul.Size = new System.Drawing.Size(39, 17);
            this.checkJul.TabIndex = 6;
            this.checkJul.Tag = "julho";
            this.checkJul.Text = "Jul";
            this.checkJul.UseVisualStyleBackColor = true;
            this.checkJul.Click += new System.EventHandler(this.CheckMes_CheckedChanged);
            // 
            // checkFev
            // 
            this.checkFev.AutoSize = true;
            this.checkFev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFev.Location = new System.Drawing.Point(91, 28);
            this.checkFev.Name = "checkFev";
            this.checkFev.Size = new System.Drawing.Size(44, 17);
            this.checkFev.TabIndex = 1;
            this.checkFev.Tag = "fevereiro";
            this.checkFev.Text = "Fev";
            this.checkFev.UseVisualStyleBackColor = true;
            this.checkFev.Click += new System.EventHandler(this.CheckMes_CheckedChanged);
            // 
            // checkJan
            // 
            this.checkJan.AutoSize = true;
            this.checkJan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkJan.Location = new System.Drawing.Point(28, 28);
            this.checkJan.Name = "checkJan";
            this.checkJan.Size = new System.Drawing.Size(43, 17);
            this.checkJan.TabIndex = 0;
            this.checkJan.Tag = "janeiro";
            this.checkJan.Text = "Jan";
            this.checkJan.UseVisualStyleBackColor = true;
            this.checkJan.CheckedChanged += new System.EventHandler(this.checkJan_CheckedChanged);
            this.checkJan.Click += new System.EventHandler(this.CheckMes_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioRP);
            this.groupBox2.Controls.Add(this.radioCV);
            this.groupBox2.Controls.Add(this.radioIN);
            this.groupBox2.Controls.Add(this.radioDL);
            this.groupBox2.Controls.Add(this.radioPE);
            this.groupBox2.Location = new System.Drawing.Point(16, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 86);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioRP
            // 
            this.radioRP.AutoSize = true;
            this.radioRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRP.Location = new System.Drawing.Point(176, 45);
            this.radioRP.Name = "radioRP";
            this.radioRP.Size = new System.Drawing.Size(98, 17);
            this.radioRP.TabIndex = 4;
            this.radioRP.TabStop = true;
            this.radioRP.Text = "Ata de Registro";
            this.radioRP.UseVisualStyleBackColor = true;
            this.radioRP.Click += new System.EventHandler(this.RadioLicitacao_Click);
            // 
            // radioCV
            // 
            this.radioCV.AutoSize = true;
            this.radioCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCV.Location = new System.Drawing.Point(176, 22);
            this.radioCV.Name = "radioCV";
            this.radioCV.Size = new System.Drawing.Size(85, 17);
            this.radioCV.TabIndex = 3;
            this.radioCV.TabStop = true;
            this.radioCV.Text = "Convite BEC";
            this.radioCV.UseVisualStyleBackColor = true;
            this.radioCV.Click += new System.EventHandler(this.RadioLicitacao_Click);
            // 
            // radioIN
            // 
            this.radioIN.AutoSize = true;
            this.radioIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIN.Location = new System.Drawing.Point(18, 45);
            this.radioIN.Name = "radioIN";
            this.radioIN.Size = new System.Drawing.Size(152, 17);
            this.radioIN.TabIndex = 2;
            this.radioIN.TabStop = true;
            this.radioIN.Text = "Inexigibilidade de Licitação";
            this.radioIN.UseVisualStyleBackColor = true;
            this.radioIN.Click += new System.EventHandler(this.RadioLicitacao_Click);
            // 
            // radioDL
            // 
            this.radioDL.AutoSize = true;
            this.radioDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDL.Location = new System.Drawing.Point(284, 22);
            this.radioDL.Name = "radioDL";
            this.radioDL.Size = new System.Drawing.Size(130, 17);
            this.radioDL.TabIndex = 1;
            this.radioDL.TabStop = true;
            this.radioDL.Text = "Dispensa de Licitação";
            this.radioDL.UseVisualStyleBackColor = true;
            this.radioDL.Click += new System.EventHandler(this.RadioLicitacao_Click);
            // 
            // radioPE
            // 
            this.radioPE.AutoSize = true;
            this.radioPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPE.Location = new System.Drawing.Point(18, 22);
            this.radioPE.Name = "radioPE";
            this.radioPE.Size = new System.Drawing.Size(109, 17);
            this.radioPE.TabIndex = 0;
            this.radioPE.TabStop = true;
            this.radioPE.Text = "Pregão Eletrônico";
            this.radioPE.UseVisualStyleBackColor = true;
            this.radioPE.Click += new System.EventHandler(this.RadioLicitacao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtDescricao.Location = new System.Drawing.Point(106, 73);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(343, 23);
            this.txtDescricao.TabIndex = 4;
            this.txtDescricao.Text = "Aquisição de ";
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(106, 38);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(144, 23);
            this.txtMemo.TabIndex = 1;
            this.txtMemo.Leave += new System.EventHandler(this.txtMemo_Leave);
            // 
            // radioAquisicao
            // 
            this.radioAquisicao.AutoSize = true;
            this.radioAquisicao.Checked = true;
            this.radioAquisicao.ForeColor = System.Drawing.Color.DarkCyan;
            this.radioAquisicao.Location = new System.Drawing.Point(350, 37);
            this.radioAquisicao.Name = "radioAquisicao";
            this.radioAquisicao.Size = new System.Drawing.Size(87, 21);
            this.radioAquisicao.TabIndex = 3;
            this.radioAquisicao.TabStop = true;
            this.radioAquisicao.Text = "Aquisição";
            this.radioAquisicao.UseVisualStyleBackColor = true;
            // 
            // radioServico
            // 
            this.radioServico.AutoSize = true;
            this.radioServico.ForeColor = System.Drawing.Color.DarkCyan;
            this.radioServico.Location = new System.Drawing.Point(266, 38);
            this.radioServico.Name = "radioServico";
            this.radioServico.Size = new System.Drawing.Size(73, 21);
            this.radioServico.TabIndex = 2;
            this.radioServico.Text = "Serviço";
            this.radioServico.UseVisualStyleBackColor = true;
            this.radioServico.CheckedChanged += new System.EventHandler(this.radioServico_CheckedChanged);
            // 
            // checkMemo
            // 
            this.checkMemo.AutoSize = true;
            this.checkMemo.ForeColor = System.Drawing.Color.DarkCyan;
            this.checkMemo.Location = new System.Drawing.Point(16, 38);
            this.checkMemo.Name = "checkMemo";
            this.checkMemo.Size = new System.Drawing.Size(69, 21);
            this.checkMemo.TabIndex = 0;
            this.checkMemo.Text = "Memo.";
            this.checkMemo.UseVisualStyleBackColor = true;
            // 
            // FormAssuntoTermo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 520);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkMemo;
        private System.Windows.Forms.CheckBox checkDez;
        private System.Windows.Forms.CheckBox checkJun;
        private System.Windows.Forms.CheckBox checkNov;
        private System.Windows.Forms.CheckBox checkMai;
        private System.Windows.Forms.CheckBox checkOut;
        private System.Windows.Forms.CheckBox checkAbr;
        private System.Windows.Forms.CheckBox checkSet;
        private System.Windows.Forms.CheckBox checkAgo;
        private System.Windows.Forms.CheckBox checkMar;
        private System.Windows.Forms.CheckBox checkJul;
        private System.Windows.Forms.CheckBox checkFev;
        private System.Windows.Forms.CheckBox checkJan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.RadioButton radioAquisicao;
        private System.Windows.Forms.RadioButton radioServico;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioRP;
        private System.Windows.Forms.RadioButton radioCV;
        private System.Windows.Forms.RadioButton radioIN;
        private System.Windows.Forms.RadioButton radioDL;
        private System.Windows.Forms.RadioButton radioPE;
    }
}