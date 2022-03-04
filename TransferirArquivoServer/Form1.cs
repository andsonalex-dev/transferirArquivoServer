using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivoServer
{
    public partial class form1 : Form
    {
        Task tarefa; //responsavel para tratar o servidor em mult tread

        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            txtPasta.Text = FTServer.PastaRecepcaoArquivos; //pegando o caminho padrão definido na classe
            FTServer.listaMensagem = listaLogs; //quando as msgs forem geradas na classe irão retornar aqui
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                FTServer.EnderecoIP = txtEnderecoIP.Text;
                FTServer.PortaHost = (int)txtPorta.Value;
                tarefa = Task.Factory.StartNew(() =>
                {
                    //método interno, lambda
                    FTServer.iniciarServidor();
                });
                
            }catch(Exception ex)
            {
                listaLogs.Invoke(new Action(() =>
                {
                    listaLogs.Items.Add("Erro ao conectar: " + ex.Message);
                    listaLogs.SetSelected(listaLogs.Items.Count - 1, true);
                }));
            }   
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Restart(); //reiniciando a aplicação do zero, matando serviços em segundo plano

            }catch(Exception ex)
            {
                listaLogs.Invoke(new Action(() =>
                {
                    listaLogs.Items.Add("Erro: " + ex.Message);
                    listaLogs.SetSelected(listaLogs.Items.Count - 1, true);
                }));

            }

        }

        private void txtPasta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                FTServer.PastaRecepcaoArquivos = dialog.SelectedPath + @"\";
                txtPasta.Text = FTServer.PastaRecepcaoArquivos;
            }
        }

    }
}
