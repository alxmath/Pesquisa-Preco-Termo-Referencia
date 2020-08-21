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
                        //Console.WriteLine(siafisico);
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
            FormPesquisa formPesquisa = new FormPesquisa();
            formPesquisa.ShowDialog();
        }
    }
}
