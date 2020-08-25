using Pesquisa_Preco_Termo_Referencia.Entities;
using Pesquisa_Preco_Termo_Referencia.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Pesquisa_Preco_Termo_Referencia.Forms
{
    public partial class FormAssuntoTermo : Form
    {
        public FormAssuntoTermo()
        {
            InitializeComponent();
        }

        string[] assuntoArray = new string[5];
        List<string> meses = new List<string>();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richAssunto.Text))
            {
                MessageBox.Show(this, "Favor inserir um assunto.", "Núcleo de Compras",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                richAssunto.Focus();
                return;
            }

            if (cbxOrdenador.Text == string.Empty)
            {
                MessageBox.Show(this, "Favor escolher o ordenador da pesquisar.",
                    "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxOrdenador.Focus();
                return;
            }

            SiafisicoReposiories.Siafisicos[0].Assunto = richAssunto.Text.Trim();

            Close();
        }

        private void FormAssuntoTermo_Load(object sender, EventArgs e)
        {
            cbxOrdenador.SelectedIndex = -1;
            CarregarOrdenadores();
        }

        private void CarregarOrdenadores()
        {

            cbxOrdenador.DataSource = null;
            List<string> ordernadores = new List<string>();
            string userPath = Application.StartupPath.ToString() + @"..\..\..\Data\ordenador.txt";

            using (StreamReader sr = File.OpenText(userPath))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string nome = line[0];
                    ordernadores.Add(nome);
                }


                cbxOrdenador.DataSource = ordernadores;

            }
        }

        private void cbxOrdenador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOrdenador.SelectedIndex == -1)
            {
                return;
            }

            string userPath = Application.StartupPath.ToString() + @"..\..\..\Data\ordenador.txt";

            using (StreamReader sr = File.OpenText(userPath))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string nome = line[0];
                    string rg = line[1];
                    string cargo = line[2];
                    string isAtual = line[3];

                    if (nome.Equals(cbxOrdenador.Text) && isAtual.Equals("Atual"))
                    {
                        OrdenadorRepository.Ordenadores.Clear();
                        OrdenadorRepository.Ordenadores.Add(new Ordenador(nome, rg, cargo, isAtual));
                    }
                }
            }
        }


        private void txtMemo_Leave(object sender, EventArgs e)
        {
            if (checkMemo.Checked && richAssunto.Text.Length == 0)
            {
                assuntoArray[0] = "Memo. " + txtMemo.Text.Trim() + " - ";
            }

        }

        private void radioServico_CheckedChanged(object sender, EventArgs e)
        {
            if (radioServico.Checked)
            {
                txtDescricao.Text = "Serviço de ";

            }
            else
            {
                txtDescricao.Text = "Aquisição de ";
            }
        }


        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescricao.Text.Trim()))
            {
                assuntoArray[1] = txtDescricao.Text.Trim();
            }
        }

        private void CheckMes_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
            {
                meses.Add((string)chk.Tag);
            }
            else
            {
                meses.Remove((string)chk.Tag);
            }
        }

        private void InserirMes(CheckBox chk)
        {
            meses.Add(chk.Text);
        }

        private void RemoverMes(CheckBox chk)
        {
            meses.Remove(chk.Text);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            if (meses.Count == 1)
            {
                assuntoArray[2] = " para suprir o mês de " + meses[0];
            }
            else if (meses.Count > 1)
            {
                assuntoArray[2] = " para suprir os meses de " + meses[0] + " a " + meses[meses.Count - 1];
            }
        }

        private void RadioLicitacao_Click(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Checked)
            {
                assuntoArray[3] = ", na modalidade de " + radio.Text + ", para este HRA";
                richAssunto.Text = string.Join("", assuntoArray);
            }
        }

        private void btnAdicionarNovo_Click(object sender, EventArgs e)
        {
            FormOrdenador formOrdenador = new FormOrdenador();
            formOrdenador.ShowDialog();
            CarregarOrdenadores();
        }
    }
}
