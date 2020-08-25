using Pesquisa_Preco_Termo_Referencia.Entities;
using Pesquisa_Preco_Termo_Referencia.Forms;
using Pesquisa_Preco_Termo_Referencia.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Pesquisa_Preco_Termo_Referencia
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void btnAbrir_Click(object sender, EventArgs e)
        {

            string path;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }
            else
            {
                return;
            }

            richTexto.Clear();

            try
            {
                List<string> relevantWords = new List<string>();
                List<Siafisico> siafisicos = new List<Siafisico>();
                Siafisico siafisico = null;

                using (StreamReader sr = File.OpenText(path))
                {
                    int i = 0;
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine().Trim();
                        if (line.Contains("PEDIDO DE COMPRA") || line.Contains("===")
                            || line.Contains("PEDIDO") || line.Contains("Item Prod")
                            || line.Contains("---") || line.Contains("SISTEMA DE MATERIAIS")
                            || line.Contains("Quantidade") || line.Trim().Length == 0)
                        {
                            continue;
                        }


                        string[] words = line.Split(' ');
                        foreach (string item in words)
                        {
                            if (!string.IsNullOrEmpty(item))
                            {
                                relevantWords.Add(item);
                            }
                        }

                        if (int.TryParse(relevantWords[0], out _) && int.TryParse(relevantWords[1], out _))
                        {
                            siafisico = new Siafisico();
                            siafisico.Item = relevantWords[0];
                            siafisico.CodigoSiafisico = relevantWords[2];
                            siafisico.Unidade = relevantWords[3];
                            siafisico.Quantidade = double.Parse(relevantWords[4]);
                            //siafisico.Now = DateTime.Now.ToLongDateString();

                            siafisicos.Add(siafisico);
                            i++;
                        }
                        else
                        {
                            siafisicos[i - 1].Descricao += line.Trim().Replace("Descricao:", "") + " ";
                        }

                        richTexto.Text += line + "\n";
                        relevantWords.Clear();
                    }
                }

                SiafisicoReposiories.Siafisicos = siafisicos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao tentar abrir arquivo de texto. Certifique-se que o arquivo que está tentando abrir contenha um pedido válido: "
                    + ex.Message, "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerarPesquisa_Click(object sender, EventArgs e)
        {


            if (richTexto.Text == string.Empty)
            {
                MessageBox.Show(this, "Favor selecionar o arquivo de texto com os dados antes de gerar a Pesquisa de Preço.",
                    "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (radioAta.Checked == false && radioPregao.Checked == false && radioDispensa.Checked == false)
            {
                MessageBox.Show(this, "Favor selecionar o tipo de licitação.",
                    "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormUser formUser = new FormUser();
            formUser.ShowDialog();

            GetOrdenador();

            if (txtProcessoPedido.Text.Trim().Length > 0)
            {
                SiafisicoReposiories.Siafisicos[0].ProcessoPedido = txtProcessoPedido.Text.Trim() + " - ";

            }
            else
            {
                SiafisicoReposiories.Siafisicos[0].ProcessoPedido = txtProcessoPedido.Text.Trim();
            }

            if (cbxLoteItem.Text == "Por lote")
            {
                SiafisicoReposiories.Siafisicos[0].TipoLicitacaoLoteItem = "Licitação por lote.";
            }

            if (radioPregao.Checked || radioConvite.Checked)
            {
                foreach (Siafisico siaf in SiafisicoReposiories.Siafisicos)
                {
                    siaf.TipoLicitacao = "O VALOR REFERENCIAL FOI OBTIDO ATRAVÉS DE PESQUISA DE PREÇO";
                }
            }
            else if (radioAta.Checked || radioDispensa.Checked)
            {
                foreach (Siafisico siaf in SiafisicoReposiories.Siafisicos)
                {
                    siaf.TipoLicitacao = "SERÁ ADQUIRIDO ATRAVÉS DA EMPRESA";
                }
            }

            FormPesquisa formPesquisa = new FormPesquisa();
            formPesquisa.ShowDialog();
        }

        private void GetOrdenador()
        {
            string ordenadorPath = Application.StartupPath.ToString() + @"..\..\..\Data\ordenador.txt";

            using (StreamReader sr = File.OpenText(ordenadorPath))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string nome = line[0];
                    string rg = line[1];
                    string cargo = line[2];
                    string isAtual = line[3];

                    if (isAtual == "Atual")
                    {
                        OrdenadorRepository.Ordenadores.Add(new Ordenador(nome, rg, cargo, isAtual));
                    }
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTermo_Click(object sender, EventArgs e)
        {
            if (richTexto.Text == string.Empty)
            {
                MessageBox.Show(this, "Favor selecionar o arquivo de texto com os dados antes de gerar o Termo de Referência.",
                    "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (radioAta.Checked == false && radioPregao.Checked == false)
            {
                MessageBox.Show(this, "Favor selecionar o tipo de licitação: Ata de Registro ou Pregão Eletrônico",
                    "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormAssuntoTermo formAssuntoTermo = new FormAssuntoTermo();
            formAssuntoTermo.ShowDialog();

            FormUser formUser = new FormUser();
            formUser.ShowDialog();

            FormTermo formTermo = new FormTermo();
            formTermo.ShowDialog();
        }

        private void radioPregao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLoteItem.Visible == true)
            {
                cbxLoteItem.Visible = false;
            }
            else
            {
                cbxLoteItem.Visible = true;
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            radioPregao.Checked = false;
            cbxLoteItem.SelectedIndex = 1;
        }

        private void linkSobre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSobre formSobre = new FormSobre();
            formSobre.ShowDialog();
        }
    }
}
