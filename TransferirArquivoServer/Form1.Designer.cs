namespace TransferirArquivoServer
{
    partial class form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnderecoIP = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.txtPasta = new System.Windows.Forms.LinkLabel();
            this.txtPorta = new System.Windows.Forms.NumericUpDown();
            this.listaLogs = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor Para Compartilhamento de Arquivos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ip para conexão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Porta";
            // 
            // txtEnderecoIP
            // 
            this.txtEnderecoIP.Location = new System.Drawing.Point(16, 108);
            this.txtEnderecoIP.Name = "txtEnderecoIP";
            this.txtEnderecoIP.Size = new System.Drawing.Size(213, 20);
            this.txtEnderecoIP.TabIndex = 3;
            this.txtEnderecoIP.Text = "127.0.0.1";
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.Green;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConectar.Location = new System.Drawing.Point(16, 134);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(83, 23);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.Brown;
            this.btnParar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnParar.Location = new System.Drawing.Point(105, 134);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 6;
            this.btnParar.Text = "Fechar";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // txtPasta
            // 
            this.txtPasta.AutoSize = true;
            this.txtPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasta.Location = new System.Drawing.Point(13, 173);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.Size = new System.Drawing.Size(109, 16);
            this.txtPasta.TabIndex = 7;
            this.txtPasta.TabStop = true;
            this.txtPasta.Text = "Selecionar pasta";
            this.txtPasta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtPasta_LinkClicked);
            // 
            // txtPorta
            // 
            this.txtPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorta.Location = new System.Drawing.Point(236, 107);
            this.txtPorta.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtPorta.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(120, 22);
            this.txtPorta.TabIndex = 8;
            this.txtPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // listaLogs
            // 
            this.listaLogs.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listaLogs.FormattingEnabled = true;
            this.listaLogs.Location = new System.Drawing.Point(16, 207);
            this.listaLogs.Name = "listaLogs";
            this.listaLogs.Size = new System.Drawing.Size(374, 225);
            this.listaLogs.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TransferirArquivoServer.Properties.Resources._3023093_200;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listaLogs);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtPasta);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtEnderecoIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "Servidor Web Socket";
            this.Load += new System.EventHandler(this.form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnderecoIP;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.LinkLabel txtPasta;
        private System.Windows.Forms.NumericUpDown txtPorta;
        private System.Windows.Forms.ListBox listaLogs;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

