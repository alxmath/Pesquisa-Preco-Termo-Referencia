using Pesquisa_Preco_Termo_Referencia.Entities;
using Pesquisa_Preco_Termo_Referencia.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pesquisa_Preco_Termo_Referencia.Forms
{
    public partial class FormTermo : Form
    {
        public FormTermo()
        {
            InitializeComponent();
        }

        private void FormTermo_Load(object sender, EventArgs e)
        {

            try
            {
                List<Siafisico> siafisicos = SiafisicoReposiories.Siafisicos;
                List<User> users = UserRepository.Users;
                List<Ordenador> ordenadores = OrdenadorRepository.Ordenadores;

                rptvTermo.LocalReport.DataSources.Clear();
                rptvTermo.LocalReport.ReportEmbeddedResource = "Pesquisa-Preco-Termo-Referencia.TermoReport.rdlc";
                //rptvTermo.LocalReport.ReportPath = "../../TermoReport.rdlc";
                rptvTermo.LocalReport.ReportPath = "TermoReport.rdlc";
                Microsoft.Reporting.WinForms.ReportDataSource ds = new Microsoft.Reporting.WinForms.ReportDataSource("TermoDS", siafisicos);
                Microsoft.Reporting.WinForms.ReportDataSource userDS = new Microsoft.Reporting.WinForms.ReportDataSource("UserDS", users);
                Microsoft.Reporting.WinForms.ReportDataSource ordenadorDS = new Microsoft.Reporting.WinForms.ReportDataSource("OrdenadorDS", ordenadores);

                rptvTermo.LocalReport.DataSources.Add(ds);
                rptvTermo.LocalReport.DataSources.Add(userDS);
                rptvTermo.LocalReport.DataSources.Add(ordenadorDS);
                ds.Value = siafisicos;
                userDS.Value = users;
                ordenadorDS.Value = ordenadores;

                rptvTermo.LocalReport.Refresh();
                this.rptvTermo.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao gerar Termo de Referência: "
                    + ex.Message, "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTermo_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserRepository.Users.Clear();
        }
    }
}
