﻿using Pesquisa_Preco_Termo_Referencia.Entities;
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

            try
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
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao carregar a tabela com os usuários: " + ex.Message,
                    "Núcleo de Finanças", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            if (dgvUsers.Rows.Count == 0)
            {
                MessageBox.Show(this, "Favor adicionar uma assinatura utilizando os campos ao lado.", "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Favor selecionar uma assinatura na tabela acima.", "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = dgvUsers.SelectedCells[0].Value.ToString();
            string rg = dgvUsers.SelectedCells[1].Value.ToString();
            string cargo = dgvUsers.SelectedCells[2].Value.ToString();

            SiafisicoReposiories.Siafisicos[0].Nome = nome;
            SiafisicoReposiories.Siafisicos[0].RG = rg;
            SiafisicoReposiories.Siafisicos[0].Cargo = cargo;

            Close();
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
                MessageBox.Show(this, "Favor escolher um cargo.", "Núcleo de Finanças", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string nome = txtNome.Text.Trim();
            string rg = txtRg.Text.Trim();
            string cargo = cbxCargo.Text;

            try
            {
                string userPath = Application.StartupPath.ToString() + @"..\..\..\Data\users.txt";
                using (StreamWriter sw = File.AppendText(userPath))
                {
                    sw.WriteLine(nome + "," + rg + "," + cargo);
                    MessageBox.Show(this, "Assinatura inserida. Agora ela estará disponível para inserções.", "Núcleo de Finanças", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SiafisicoReposiories.Siafisicos[0].Nome = nome;
                    SiafisicoReposiories.Siafisicos[0].RG = rg;
                    SiafisicoReposiories.Siafisicos[0].Cargo = cargo;

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Não foi possível adicionar usuário: " + ex.Message,
                    "Núcleo de Finanças", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidaTextBox(TextBox txt, string message)
        {
            if (string.IsNullOrEmpty(txt.Text.Trim()))
            {
                MessageBox.Show(this, message, "Núcleo de Finanças", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                return false;
            }

            return true;
        }

        private void FormUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrEmpty(SiafisicoReposiories.Siafisicos[0].Nome) && dgvUsers.Rows.Count != 0)
            {
                string nome = dgvUsers.SelectedCells[0].Value.ToString();
                string rg = dgvUsers.SelectedCells[1].Value.ToString();
                string cargo = dgvUsers.SelectedCells[2].Value.ToString();

                SiafisicoReposiories.Siafisicos[0].Nome = nome;
                SiafisicoReposiories.Siafisicos[0].RG = rg;
                SiafisicoReposiories.Siafisicos[0].Cargo = cargo;
            }
        }
    }
}
