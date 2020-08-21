using Pesquisa_Preco_Termo_Referencia.Entities;
using Pesquisa_Preco_Termo_Referencia.Forms;
using Pesquisa_Preco_Termo_Referencia.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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

      

                    //var isNumeric = int.TryParse(relevantWords[0], out _);

                    if (int.TryParse(relevantWords[0], out _) && int.TryParse(relevantWords[1], out _))
                    {
                        siafisico = new Siafisico();
                        siafisico.Item = relevantWords[0];
                        siafisico.CodigoSiafisico = relevantWords[2];
                        siafisico.Unidade = relevantWords[3];
                        siafisico.Quantidade = double.Parse(relevantWords[4]);
                        
                        if (radioPregao.Checked)
                        {
                            siafisico.TipoLicitacao = "O VALOR REFERENCIAL FOI OBTIDO ATRAVÉS DE PESQUISA DE PREÇO";
                        }
                        else
                        {
                            siafisico.TipoLicitacao = "SERÁ ADQUIRIDO ATRAVÉS DA EMPRESA";
                        }

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

            foreach (Siafisico siaf in siafisicos)
            {
                Console.WriteLine(siaf);
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
            SiafisicoReposiories.Siafisicos[0].ProcessoPedido = txtProcessoPedido.Text.Trim();

            FormPesquisa formPesquisa = new FormPesquisa();
            formPesquisa.ShowDialog();
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
        }
    }
}
