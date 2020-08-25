using Pesquisa_Preco_Termo_Referencia.Entities;
using Pesquisa_Preco_Termo_Referencia.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Pesquisa_Preco_Termo_Referencia.Forms
{
    public partial class FormPesquisa : Form
    {
        public FormPesquisa()
        {
            InitializeComponent();
        }

        private void FormPesquisa_Load(object sender, EventArgs e)
        {
            try
            {
                List<Siafisico> siafisicos = SiafisicoReposiories.Siafisicos;
                List<User> users = UserRepository.Users;
                List<Ordenador> ordenadores = OrdenadorRepository.Ordenadores;

                rptv1.LocalReport.DataSources.Clear();
                rptv1.LocalReport.ReportEmbeddedResource = "Pesquisa-Preco-Termo-Referencia.PesquisaReport.rdlc";
                rptv1.LocalReport.ReportPath = "../../PesquisaReport.rdlc";
                Microsoft.Reporting.WinForms.ReportDataSource ds = new Microsoft.Reporting.WinForms.ReportDataSource("SiafisicoDS", siafisicos);
                Microsoft.Reporting.WinForms.ReportDataSource userDS = new Microsoft.Reporting.WinForms.ReportDataSource("UserDS", users);
                Microsoft.Reporting.WinForms.ReportDataSource ordenadorDS = new Microsoft.Reporting.WinForms.ReportDataSource("OrdenadorDS", ordenadores);

                rptv1.LocalReport.DataSources.Add(ds);
                rptv1.LocalReport.DataSources.Add(userDS);
                rptv1.LocalReport.DataSources.Add(ordenadorDS);

                ds.Value = siafisicos;
                userDS.Value = users;
                ordenadorDS.Value = ordenadores;

                rptv1.LocalReport.Refresh();

                this.rptv1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao gerar Pesquisa de Preço: "
                    + ex.Message, "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPesquisa_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserRepository.Users.Clear();
        }
    }
}
