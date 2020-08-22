using Pesquisa_Preco_Termo_Referencia.Entities;
using Pesquisa_Preco_Termo_Referencia.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Pesquisa_Preco_Termo_Referencia.Forms
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            
            string userPath = Application.StartupPath.ToString() + @"..\..\..\Data\users.txt";

            List<User> users = new List<User>();

            using (StreamReader sr = File.OpenText(userPath))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string nome = line[0];
                    string rg = line[1];
                    string cargo = line[2];
                    users.Add(new User(nome, rg, cargo));

                }
            }

            dgvUsers.DataSource = users;
            DataGridViewColumn column = dgvUsers.Columns["Nome"];
            column.Width = 250;

            column = dgvUsers.Columns["RG"];
            column.Width = 120;

            column = dgvUsers.Columns["Cargo"];
            column.Width = 210;

        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            if (dgvUsers.Rows.Count == 0)
            {
                return;
            }

            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Favor selecionar uma assinatura na tabela acima.", "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dgvUsers.CurrentRow.Index;

            string nome = dgvUsers.SelectedCells[0].Value.ToString();
            string rg = dgvUsers.SelectedCells[1].Value.ToString();
            string cargo = dgvUsers.SelectedCells[2].Value.ToString();

            SiafisicoReposiories.Siafisicos[0].Nome = nome;
            SiafisicoReposiories.Siafisicos[0].RG = rg;
            SiafisicoReposiories.Siafisicos[0].Cargo = cargo;

            Close();
        }
    }
}
