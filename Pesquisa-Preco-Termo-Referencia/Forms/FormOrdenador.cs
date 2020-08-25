using System;
using System.IO;
using System.Windows.Forms;

namespace Pesquisa_Preco_Termo_Referencia.Forms
{
    public partial class FormOrdenador : Form
    {
        public FormOrdenador()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidaTextBox(txtNome, "Favor inserir um nome."))
            {
                return;
            }

            if (!ValidaTextBox(txtRg, "Favor inserir um RG válido."))
            {
                return;
            }

            if (string.IsNullOrEmpty(cbxCargo.Text))
            {
                MessageBox.Show(this, "Favor escolher um cargo.",
                    "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = txtNome.Text.Trim();
            string rg = txtRg.Text.Trim();
            string cargo = cbxCargo.Text;
            string isAtual = "Não";

            if (checkOrdenadorAtual.Checked)
            {
                isAtual = "Atual";
            }

            try
            {
                //string ordenadorPath = Application.StartupPath.ToString() + @"..\..\..\Data\ordenador.txt";
                string ordenadorPath = Application.StartupPath.ToString() + @"\Data\ordenador.txt";
                using (StreamWriter sw = File.AppendText(ordenadorPath))
                {
                    sw.WriteLine(nome + "," + rg + "," + cargo + "," + isAtual);
                    MessageBox.Show(this, "Ordenador inserido.", "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Não foi possível adicionar ordenador: " + ex.Message,
                    "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaTextBox(TextBox txt, string message)
        {
            if (string.IsNullOrEmpty(txt.Text.Trim()))
            {
                MessageBox.Show(this, message, "Núcleo de Compras",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                return false;
            }

            return true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
