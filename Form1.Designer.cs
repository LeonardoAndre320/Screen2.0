namespace Screen2._0
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.Titulo = new System.Windows.Forms.Label();
            this.Barra = new System.Windows.Forms.Panel();
            this.bntMinimizar = new System.Windows.Forms.PictureBox();
            this.bntFechar = new System.Windows.Forms.PictureBox();
            this.ImagensBotoes = new System.Windows.Forms.ImageList(this.components);
            this.bntAtivado = new System.Windows.Forms.PictureBox();
            this.grupoConfig = new System.Windows.Forms.GroupBox();
            this.lblDireita = new System.Windows.Forms.Label();
            this.lblEsquerda = new System.Windows.Forms.Label();
            this.lblInferior = new System.Windows.Forms.Label();
            this.lblUltimaImagem = new System.Windows.Forms.Label();
            this.UltimaImagem = new System.Windows.Forms.PictureBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.ListaFormatos = new System.Windows.Forms.ListBox();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.TelaTamanho = new System.Windows.Forms.PictureBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblMais = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.SalvarArquivo = new System.Windows.Forms.SaveFileDialog();
            this.lblSaida = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.ImagensAtivado = new System.Windows.Forms.ImageList(this.components);
            this.Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntAtivado)).BeginInit();
            this.grupoConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltimaImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelaTamanho)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.Titulo.Location = new System.Drawing.Point(3, 3);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(101, 24);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Screen 2.0";
            // 
            // Barra
            // 
            this.Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Barra.Controls.Add(this.bntMinimizar);
            this.Barra.Controls.Add(this.bntFechar);
            this.Barra.Controls.Add(this.Titulo);
            this.Barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra.Location = new System.Drawing.Point(0, 0);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(573, 30);
            this.Barra.TabIndex = 1;
            // 
            // bntMinimizar
            // 
            this.bntMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bntMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("bntMinimizar.Image")));
            this.bntMinimizar.Location = new System.Drawing.Point(513, 0);
            this.bntMinimizar.Name = "bntMinimizar";
            this.bntMinimizar.Size = new System.Drawing.Size(30, 30);
            this.bntMinimizar.TabIndex = 2;
            this.bntMinimizar.TabStop = false;
            this.bntMinimizar.Click += new System.EventHandler(this.bntMinimizar_Click);
            this.bntMinimizar.MouseEnter += new System.EventHandler(this.MinimizarEntrar);
            this.bntMinimizar.MouseLeave += new System.EventHandler(this.MinimizarSair);
            // 
            // bntFechar
            // 
            this.bntFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bntFechar.Image = ((System.Drawing.Image)(resources.GetObject("bntFechar.Image")));
            this.bntFechar.Location = new System.Drawing.Point(543, 0);
            this.bntFechar.Name = "bntFechar";
            this.bntFechar.Size = new System.Drawing.Size(30, 30);
            this.bntFechar.TabIndex = 1;
            this.bntFechar.TabStop = false;
            this.bntFechar.Click += new System.EventHandler(this.bntFechar_Click);
            this.bntFechar.MouseEnter += new System.EventHandler(this.FecharEntrar);
            this.bntFechar.MouseLeave += new System.EventHandler(this.FecharSair);
            // 
            // ImagensBotoes
            // 
            this.ImagensBotoes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagensBotoes.ImageStream")));
            this.ImagensBotoes.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagensBotoes.Images.SetKeyName(0, "Fechar1.png");
            this.ImagensBotoes.Images.SetKeyName(1, "Fechar2.png");
            this.ImagensBotoes.Images.SetKeyName(2, "Menos1.png");
            this.ImagensBotoes.Images.SetKeyName(3, "Menos2.png");
            // 
            // bntAtivado
            // 
            this.bntAtivado.BackColor = System.Drawing.Color.Lime;
            this.bntAtivado.Image = ((System.Drawing.Image)(resources.GetObject("bntAtivado.Image")));
            this.bntAtivado.Location = new System.Drawing.Point(461, 214);
            this.bntAtivado.Name = "bntAtivado";
            this.bntAtivado.Size = new System.Drawing.Size(100, 20);
            this.bntAtivado.TabIndex = 2;
            this.bntAtivado.TabStop = false;
            this.bntAtivado.Click += new System.EventHandler(this.Ativacao);
            // 
            // grupoConfig
            // 
            this.grupoConfig.Controls.Add(this.lblDireita);
            this.grupoConfig.Controls.Add(this.lblEsquerda);
            this.grupoConfig.Controls.Add(this.lblInferior);
            this.grupoConfig.Controls.Add(this.lblUltimaImagem);
            this.grupoConfig.Controls.Add(this.UltimaImagem);
            this.grupoConfig.Controls.Add(this.lblFormato);
            this.grupoConfig.Controls.Add(this.ListaFormatos);
            this.grupoConfig.Controls.Add(this.lblSuperior);
            this.grupoConfig.Controls.Add(this.TelaTamanho);
            this.grupoConfig.Controls.Add(this.lblBuscar);
            this.grupoConfig.Controls.Add(this.lblNome);
            this.grupoConfig.Controls.Add(this.lblLocal);
            this.grupoConfig.Controls.Add(this.lblMais);
            this.grupoConfig.Controls.Add(this.txtNumero);
            this.grupoConfig.Controls.Add(this.txtNome);
            this.grupoConfig.Controls.Add(this.txtLocal);
            this.grupoConfig.ForeColor = System.Drawing.Color.White;
            this.grupoConfig.Location = new System.Drawing.Point(12, 36);
            this.grupoConfig.Name = "grupoConfig";
            this.grupoConfig.Size = new System.Drawing.Size(549, 172);
            this.grupoConfig.TabIndex = 5;
            this.grupoConfig.TabStop = false;
            this.grupoConfig.Text = "Configuraçoes";
            // 
            // lblDireita
            // 
            this.lblDireita.AutoSize = true;
            this.lblDireita.Location = new System.Drawing.Point(339, 101);
            this.lblDireita.Name = "lblDireita";
            this.lblDireita.Size = new System.Drawing.Size(24, 13);
            this.lblDireita.TabIndex = 15;
            this.lblDireita.Text = "0px";
            this.lblDireita.Click += new System.EventHandler(this.ClickDireita);
            // 
            // lblEsquerda
            // 
            this.lblEsquerda.AutoSize = true;
            this.lblEsquerda.Location = new System.Drawing.Point(203, 101);
            this.lblEsquerda.Name = "lblEsquerda";
            this.lblEsquerda.Size = new System.Drawing.Size(24, 13);
            this.lblEsquerda.TabIndex = 14;
            this.lblEsquerda.Text = "0px";
            this.lblEsquerda.Click += new System.EventHandler(this.ClickEsquerda);
            // 
            // lblInferior
            // 
            this.lblInferior.AutoSize = true;
            this.lblInferior.Location = new System.Drawing.Point(230, 156);
            this.lblInferior.Name = "lblInferior";
            this.lblInferior.Size = new System.Drawing.Size(24, 13);
            this.lblInferior.TabIndex = 13;
            this.lblInferior.Text = "0px";
            this.lblInferior.Click += new System.EventHandler(this.ClickInferior);
            // 
            // lblUltimaImagem
            // 
            this.lblUltimaImagem.AutoSize = true;
            this.lblUltimaImagem.Location = new System.Drawing.Point(446, 83);
            this.lblUltimaImagem.Name = "lblUltimaImagem";
            this.lblUltimaImagem.Size = new System.Drawing.Size(78, 13);
            this.lblUltimaImagem.TabIndex = 12;
            this.lblUltimaImagem.Text = "Ultima imagem:";
            // 
            // UltimaImagem
            // 
            this.UltimaImagem.Location = new System.Drawing.Point(447, 101);
            this.UltimaImagem.Name = "UltimaImagem";
            this.UltimaImagem.Size = new System.Drawing.Size(96, 54);
            this.UltimaImagem.TabIndex = 11;
            this.UltimaImagem.TabStop = false;
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(6, 83);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(48, 13);
            this.lblFormato.TabIndex = 10;
            this.lblFormato.Text = "Formato:";
            // 
            // ListaFormatos
            // 
            this.ListaFormatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ListaFormatos.ForeColor = System.Drawing.Color.White;
            this.ListaFormatos.FormattingEnabled = true;
            this.ListaFormatos.Items.AddRange(new object[] {
            "BMP",
            "ICON",
            "JPEG",
            "PNG"});
            this.ListaFormatos.Location = new System.Drawing.Point(9, 99);
            this.ListaFormatos.Name = "ListaFormatos";
            this.ListaFormatos.Size = new System.Drawing.Size(120, 56);
            this.ListaFormatos.TabIndex = 3;
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.Location = new System.Drawing.Point(230, 83);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(24, 13);
            this.lblSuperior.TabIndex = 7;
            this.lblSuperior.Text = "0px";
            this.lblSuperior.Click += new System.EventHandler(this.ClickSuperior);
            // 
            // TelaTamanho
            // 
            this.TelaTamanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TelaTamanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TelaTamanho.Location = new System.Drawing.Point(233, 99);
            this.TelaTamanho.Name = "TelaTamanho";
            this.TelaTamanho.Size = new System.Drawing.Size(96, 54);
            this.TelaTamanho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TelaTamanho.TabIndex = 6;
            this.TelaTamanho.TabStop = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(522, 20);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(21, 20);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "...";
            this.lblBuscar.Click += new System.EventHandler(this.lblBuscar_Click);
            this.lblBuscar.MouseEnter += new System.EventHandler(this.SelecionarBuscar);
            this.lblBuscar.MouseLeave += new System.EventHandler(this.DesSelecionarBuscar);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(6, 23);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(36, 13);
            this.lblLocal.TabIndex = 3;
            this.lblLocal.Text = "Local:";
            // 
            // lblMais
            // 
            this.lblMais.AutoSize = true;
            this.lblMais.Location = new System.Drawing.Point(470, 49);
            this.lblMais.Name = "lblMais";
            this.lblMais.Size = new System.Drawing.Size(13, 13);
            this.lblMais.TabIndex = 2;
            this.lblMais.Text = "+";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtNumero.ForeColor = System.Drawing.Color.White;
            this.txtNumero.Location = new System.Drawing.Point(489, 46);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(54, 20);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPrecionada);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(48, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(416, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPrecionada);
            // 
            // txtLocal
            // 
            this.txtLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtLocal.ForeColor = System.Drawing.Color.White;
            this.txtLocal.Location = new System.Drawing.Point(48, 20);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(468, 20);
            this.txtLocal.TabIndex = 0;
            this.txtLocal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPrecionada);
            this.txtLocal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TeclaSolta);
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.ForeColor = System.Drawing.Color.White;
            this.lblSaida.Location = new System.Drawing.Point(12, 211);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(37, 13);
            this.lblSaida.TabIndex = 6;
            this.lblSaida.Text = "Saida:";
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // ImagensAtivado
            // 
            this.ImagensAtivado.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagensAtivado.ImageStream")));
            this.ImagensAtivado.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagensAtivado.Images.SetKeyName(0, "Ativado.png");
            this.ImagensAtivado.Images.SetKeyName(1, "Desativado.png");
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(573, 242);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.grupoConfig);
            this.Controls.Add(this.bntAtivado);
            this.Controls.Add(this.Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Barra.ResumeLayout(false);
            this.Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntAtivado)).EndInit();
            this.grupoConfig.ResumeLayout(false);
            this.grupoConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltimaImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelaTamanho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Panel Barra;
        private System.Windows.Forms.PictureBox bntMinimizar;
        private System.Windows.Forms.PictureBox bntFechar;
        private System.Windows.Forms.ImageList ImagensBotoes;
        private System.Windows.Forms.PictureBox bntAtivado;
        private System.Windows.Forms.GroupBox grupoConfig;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblMais;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.PictureBox TelaTamanho;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.SaveFileDialog SalvarArquivo;
        private System.Windows.Forms.ListBox ListaFormatos;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.PictureBox UltimaImagem;
        private System.Windows.Forms.Label lblUltimaImagem;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Label lblInferior;
        private System.Windows.Forms.Label lblEsquerda;
        private System.Windows.Forms.Label lblDireita;
        private System.Windows.Forms.ImageList ImagensAtivado;
    }
}

