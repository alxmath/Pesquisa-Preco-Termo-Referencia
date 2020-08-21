using Pesquisa_Preco_Termo_Referencia.Entities;
using Pesquisa_Preco_Termo_Referencia.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                rptvTermo.LocalReport.DataSources.Clear();
                rptvTermo.LocalReport.ReportEmbeddedResource = "Pesquisa-Preco-Termo-Referencia.TermoReport.rdlc";
                rptvTermo.LocalReport.ReportPath = "../../TermoReport.rdlc";
                Microsoft.Reporting.WinForms.ReportDataSource ds = new Microsoft.Reporting.WinForms.ReportDataSource("TermoDS", siafisicos);

                rptvTermo.LocalReport.DataSources.Add(ds);
                ds.Value = siafisicos;

                rptvTermo.LocalReport.Refresh();

                this.rptvTermo.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao gerar Termo de Referência: "
                    + ex.Message, "Núcleo de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
