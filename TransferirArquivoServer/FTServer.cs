using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivoServer
{
    internal class FTServer
    {
        static IPEndPoint ipEnd_servidor;
        static Socket sock_Servidor;
        public static string EnderecoIP = "127.0.0.1";
        public static int PortaHost = 1000;
        public static string PastaRecepcaoArquivos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\"; //chegando a pasta documentos
        public static ListBox listaMensagem; //log


        public static void iniciarServidor()
        {
            try
            {
                ipEnd_servidor = new IPEndPoint(IPAddress.Parse(EnderecoIP), PortaHost);

                sock_Servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //iniciando o socket, tipo internetowok, tipo strem e o protocolo tcp para utilizar o ip
                sock_Servidor.Bind(ipEnd_servidor); //associando o socket ao endpoint local


            }catch(Exception ex)
            {
                listaMensagem.Invoke(new Action(() =>
                {
                    listaMensagem.Items.Add("Erro ao iniciar servidor: " + ex.Message);
                    listaMensagem.SetSelected(listaMensagem.Items.Count - 1, true);
                })); //alterar a listbox em uma thread diferente
                return;
            }

            try
            {
                sock_Servidor.Listen(100); //escuta até 100 conexões
                listaMensagem.Invoke(new Action(() =>
                {
                    listaMensagem.Items.Add("Servidor em atendimento, aguardando recebimento de arquivos... ");
                    listaMensagem.SetSelected(listaMensagem.Items.Count - 1, true);
                }));

                Socket clienteSock = sock_Servidor.Accept();//escuta a conexão e aceita a conexão do cliente
                clienteSock.ReceiveBufferSize = 16384; //tamanho de 16kb do buffer

                //para transferir arquivos sempre trabalhar com bytes

                byte[] dadosCliente = new byte[1024 * 50000]; // 50mb de tamanho de arquivo máximo
                int tamanhoBytesRecebidos = clienteSock.Receive(dadosCliente, dadosCliente.Length, 0);
                int tamanhoNomeArquivo = BitConverter.ToInt32(dadosCliente, 0);
                string nomeArquivo = Encoding.UTF8.GetString(dadosCliente, 4, tamanhoNomeArquivo);

                BinaryWriter bWrite = new BinaryWriter(File.Open(PastaRecepcaoArquivos + nomeArquivo, FileMode.Append));
                //Append adiciona mais conteudo e não sobrescreve 

                bWrite.Write(dadosCliente, 4 + tamanhoNomeArquivo, tamanhoBytesRecebidos - 4 - tamanhoNomeArquivo); //grava as informações

                //verificando os bytes recebidos
                while(tamanhoBytesRecebidos > 0)
                {
                    tamanhoBytesRecebidos = clienteSock.Receive(dadosCliente, dadosCliente.Length, 0);
                    if(tamanhoBytesRecebidos == 0)
                    {
                        bWrite.Close();
                    }
                    else
                    {
                        bWrite.Write(dadosCliente, 0, tamanhoBytesRecebidos);
                    }
                   
                }
                listaMensagem.Invoke(new Action(() =>
                {
                    listaMensagem.Items.Add("Arquivo recebido e arquivado [" + nomeArquivo + "] (" + (tamanhoBytesRecebidos - 4 - tamanhoNomeArquivo) + " bytes recebido)");
                    listaMensagem.SetSelected(listaMensagem.Items.Count - 1, true);
                }));
                bWrite.Close();
                clienteSock.Close();
            }
            catch (SocketException ex)
            {
                listaMensagem.Invoke(new Action(() =>
                {
                    listaMensagem.Items.Add("Erro ao receber arquivo: " + ex.Message);
                    listaMensagem.SetSelected(listaMensagem.Items.Count - 1, true);
                })); //alterar a listbox em uma thread diferente
            }
            finally
            {
                sock_Servidor.Close();
                sock_Servidor.Dispose(); //se livra de tudo, release
                iniciarServidor(); //reiniciando o serviço, deixando o servidor ativo
            } //fechar todas as conexões quando necessário
        }
    }
}
