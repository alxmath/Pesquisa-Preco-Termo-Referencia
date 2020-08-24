using Pesquisa_Preco_Termo_Referencia.Entities;
using Pesquisa_Preco_Termo_Referencia.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pesquisa_Preco_Termo_Referencia.Forms
{
    public partial class FormAssuntoTermo : Form
    {
        public FormAssuntoTermo()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richAssunto.Text))
            {
                MessageBox.Show(this, "Favor inserir um assunto.", "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                richAssunto.Focus();
                return;
            }

            if (cbxOrdenador.Text == string.Empty)
            {
                MessageBox.Show(this, "Favor escolher o ordenador da pesquisar.", "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxOrdenador.Focus();
                return;
            }

            SiafisicoReposiories.Siafisicos[0].Assunto = richAssunto.Text.Trim();

            Close();
        }

        private void FormAssuntoTermo_Load(object sender, EventArgs e)
        {
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

            cbxOrdenador.SelectedIndex = -1;
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

                    if (nome == cbxOrdenador.Text)
                    {
                        SiafisicoReposiories.Siafisicos[0].Nome = nome;
                        SiafisicoReposiories.Siafisicos[0].RG = rg;
                        SiafisicoReposiories.Siafisicos[0].Cargo = cargo;
                    }
                }      
            }
        }
    }
}
