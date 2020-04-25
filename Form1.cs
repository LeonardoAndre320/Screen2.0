using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Media;

namespace Screen2._0
{
    public partial class TelaPrincipal : Form
    {

        int X = 0;
        int Y = 0;

        bool Ativado = false;
        public TelaPrincipal()
        {
            InitializeComponent();

            ListaFormatos.SelectedIndex = 3;//Seleciona Png
            TelaTamanho.Location = new Point(Size.Width / 2 - TelaTamanho.Size.Width / 2, TelaTamanho.Location.Y);//Centraliza a tela de tamanho

            #region Controle de movimento da janela
            Barra.MouseDown += new MouseEventHandler(MouseBaixo);
            Barra.MouseMove += new MouseEventHandler(MovimentoMouse);

            Titulo.MouseDown += new MouseEventHandler(MouseBaixo);
            Titulo.MouseMove += new MouseEventHandler(MovimentoMouse);
            #endregion
        }

        #region Movimentacao da janela
        private void MouseBaixo(object sender,MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }
        private void MovimentoMouse(object sender,MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
        #endregion

        #region Controle Janela
        private void bntFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bntMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void MinimizarEntrar(object sender,EventArgs e)
        {
            bntMinimizar.Image = ImagensBotoes.Images[3];
        }
        private void MinimizarSair(object sender, EventArgs e)
        {
            bntMinimizar.Image = ImagensBotoes.Images[2];
        }
        private void FecharEntrar(object sender, EventArgs e)
        {
            bntFechar.Image = ImagensBotoes.Images[1];
        }
        private void FecharSair(object sender, EventArgs e)
        {
            if(ImagensBotoes.Images.Count > 0)
            bntFechar.Image = ImagensBotoes.Images[0];
        }
        #endregion

        #region Buscar
        private void SelecionarBuscar(object sender,EventArgs e)
        {
            if(!Ativado)
            lblBuscar.BackColor = Color.FromArgb(100,100,100);
        }
        private void DesSelecionarBuscar(object sende,EventArgs e)
        {
            lblBuscar.BackColor = Color.FromArgb(80,80,80);
        }
        private void lblBuscar_Click(object sender, EventArgs e)
        {
            if (!Ativado)
            {
                //Coloca o nome e local se existir
                if (txtNome.Text == "")
                {
                    SalvarArquivo.FileName = "Imagem";
                }
                else
                {
                    SalvarArquivo.FileName = txtNome.Text;
                }

                SalvarArquivo.Filter = "Arquivos de imagens|*.bmp;*.icon;*.jpeg;*.png|Todos os arquivos|*.*";
                SalvarArquivo.Title = "Escolha aonde vai salvar sua imagem";
                SalvarArquivo.ShowDialog();
            }
        }
        #endregion

        private Bitmap CortarImagem(Bitmap Imagem, int Superior = 0, int Inferior = 0, int Esquerda = 0, int Direita = 0)
        {


            return Imagem;
        }

        #region Controla as cores e funcoes dos cortes
        int CorteSelecionado = 0;
        int CorteSuperior = 0;
        int CorteInferior = 0;
        int CorteEsquerda = 0;
        int CorteDireita = 0;
        
        private void ClickSuperior(object sender, EventArgs e)
        {
            if(CorteSelecionado == 1)
            {
                CorteSelecionado = 0;
            }
            else
            {
                CorteSelecionado = 1; 
            }
        }
        private void ClickInferior(object sender, EventArgs e)
        {
            if (CorteSelecionado == 2)
            {
                CorteSelecionado = 0;
            }
            else
            {
                CorteSelecionado = 2;
            }
        }
        private void ClickEsquerda(object sender, EventArgs e)
        {
            if (CorteSelecionado == 3)
            {
                CorteSelecionado = 0;
            }
            else
            {
                CorteSelecionado = 3;
            }
        }
        private void ClickDireita(object sender, EventArgs e)
        {
            if (CorteSelecionado == 4)
            {
                CorteSelecionado = 0;
            }
            else
            {
                CorteSelecionado = 4;
            }
        }

        #endregion
        private void Temporizador_Tick(object sender, EventArgs e)
        {
            #region Verefica o clique das setas

            lblSuperior.Text = CorteSuperior + "px";
            lblInferior.Text = CorteInferior + "px";
            lblEsquerda.Text = CorteEsquerda + "px";
            lblDireita.Text = CorteDireita + "px";

            #endregion

            #region Mantem as labels de tamanho no centro

            //                               distancia da tela          tamanho da tela / 2        tamanho label / 2           altura normal
            lblSuperior.Location = new Point(TelaTamanho.Location.X + TelaTamanho.Size.Width / 2 - lblSuperior.Size.Width / 2, lblSuperior.Location.Y);
            lblInferior.Location = new Point(TelaTamanho.Location.X + TelaTamanho.Size.Width / 2 - lblInferior.Size.Width / 2, lblInferior.Location.Y);

            lblEsquerda.Location = new Point(TelaTamanho.Location.X - lblEsquerda.Size.Width, TelaTamanho.Location.Y + TelaTamanho.Size.Height / 2 - lblEsquerda.Size.Height / 2);
            lblDireita.Location = new Point(TelaTamanho.Location.X + 96, TelaTamanho.Location.Y + TelaTamanho.Size.Height / 2 - lblDireita.Size.Height / 2);

            #endregion

            #region Muda a cor dos corte de tamanho

            switch (CorteSelecionado)
            {
                case 1:
                    lblSuperior.ForeColor = Color.SteelBlue;
                    lblInferior.ForeColor = Color.White;
                    lblEsquerda.ForeColor = Color.White;
                    lblDireita.ForeColor = Color.White;
                    break;
                case 2:
                    lblSuperior.ForeColor = Color.White;
                    lblInferior.ForeColor = Color.SteelBlue;
                    lblEsquerda.ForeColor = Color.White;
                    lblDireita.ForeColor = Color.White;
                    break;
                case 3:
                    lblSuperior.ForeColor = Color.White;
                    lblInferior.ForeColor = Color.White;
                    lblEsquerda.ForeColor = Color.SteelBlue;
                    lblDireita.ForeColor = Color.White;
                    break;
                case 4:
                    lblSuperior.ForeColor = Color.White;
                    lblInferior.ForeColor = Color.White;
                    lblEsquerda.ForeColor = Color.White;
                    lblDireita.ForeColor = Color.SteelBlue;
                    break;
                default:
                    if (!Ativado)
                    {
                        lblSuperior.ForeColor = Color.White;
                        lblInferior.ForeColor = Color.White;
                        lblEsquerda.ForeColor = Color.White;
                        lblDireita.ForeColor = Color.White;
                    }
                    break;
            }

            #endregion

            #region Controla a imagem de ativado
            if (Ativado)
            {
                bntAtivado.Image = ImagensAtivado.Images[0];
                DesAtivarControles(true);
            }
            else
            {
                bntAtivado.Image = ImagensAtivado.Images[1];
                DesAtivarControles(false);
            }
            #endregion


            lblSaida.Text = Ativado + "," + CorteSelecionado + ",";
        }

        private void TeclaPrecionada(object sender,KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                if (CorteSelecionado == 1)
                {
                    CorteSuperior++;
                }
                else if(CorteSelecionado == 2)
                {
                    CorteInferior++;
                }
                else if(CorteSelecionado == 3)
                {
                    CorteEsquerda++;
                }
                else if(CorteSelecionado == 4)
                {
                    CorteDireita++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (CorteSelecionado == 1)
                {
                    if(CorteSuperior <= 0)
                    {
                        SystemSounds.Exclamation.Play();
                    }
                    else
                    {
                        CorteSuperior--;
                    }
                }
                else if (CorteSelecionado == 2)
                {
                    if (CorteInferior <= 0)
                    {
                        SystemSounds.Exclamation.Play();
                    }
                    else
                    {
                        CorteInferior--;
                    }
                }
                else if(CorteSelecionado == 3)
                {
                    if (CorteEsquerda <= 0)
                    {
                        SystemSounds.Exclamation.Play();
                    }
                    else
                    {
                        CorteEsquerda--;
                    }
                }
                else if(CorteSelecionado == 4)
                {
                    if(CorteDireita <= 0)
                    {
                        SystemSounds.Exclamation.Play();
                    }
                    else
                    {
                        CorteDireita--;
                    }
                }
            }
            #region Cria a imagem de previsao de corte

            Bitmap FuturoCorte = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            for (int x = 0; x < FuturoCorte.Width; x++)
            {
                for (int y = 0; y < FuturoCorte.Height; y++)
                {
                    FuturoCorte.SetPixel(x, y, Color.Red);
                }
            }
            TelaTamanho.Image = FuturoCorte;
            #endregion
        }

        private void Ativacao(object sender,EventArgs e)
        {
            if(Ativado)
            {
                Ativado = false;
            }
            else
            {
                Ativado = true;
            }
        }

        private void DesAtivarControles(bool DA)
        {
            if(DA)
            {
                txtLocal.Enabled = false;
                txtNome.Enabled = false;
                txtNumero.Enabled = false;
                ListaFormatos.Enabled = false;

                lblLocal.ForeColor = Color.DarkGray;
                lblNome.ForeColor = Color.DarkGray;
                lblMais.ForeColor = Color.DarkGray;
                lblFormato.ForeColor = Color.DarkGray;
                lblSuperior.ForeColor = Color.DarkGray;
                lblInferior.ForeColor = Color.DarkGray;
                lblEsquerda.ForeColor = Color.DarkGray;
                lblDireita.ForeColor = Color.DarkGray;
                lblUltimaImagem.ForeColor = Color.DarkGray;
                lblBuscar.ForeColor = Color.DarkGray;

                CorteSelecionado = 0;
            }
            else
            {
                txtLocal.Enabled = true;
                txtNome.Enabled = true;
                txtNumero.Enabled = true;
                ListaFormatos.Enabled = true;

                lblLocal.ForeColor = Color.White;
                lblNome.ForeColor = Color.White;
                lblMais.ForeColor = Color.White;
                lblFormato.ForeColor = Color.White;
                lblUltimaImagem.ForeColor = Color.White;
                lblBuscar.ForeColor = Color.White;
            }
        }
    }
}
