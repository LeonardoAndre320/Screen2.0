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

namespace Screen2._0
{
    public partial class TelaPrincipal : Form
    {

        int X = 0;
        int Y = 0;
        public TelaPrincipal()
        {

            InitializeComponent();

            ListaFormatos.SelectedIndex = 3;//Seleciona Png
            Barra.MouseDown += new MouseEventHandler(MouseBaixo);
            Barra.MouseMove += new MouseEventHandler(MovimentoMouse);

            Titulo.MouseDown += new MouseEventHandler(MouseBaixo);
            Titulo.MouseMove += new MouseEventHandler(MovimentoMouse);
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
        #endregion

        #region Buscar
        private void SelecionarBuscar(object sender,EventArgs e)
        {
            lblBuscar.BackColor = Color.FromArgb(100,100,100);
        }
        private void DesSelecionarBuscar(object sende,EventArgs e)
        {
            lblBuscar.BackColor = Color.FromArgb(80,80,80);
        }
        private void lblBuscar_Click(object sender, EventArgs e)
        {
            //Coloca o nome e local se existir
            if(txtNome.Text == "")
            {
                SalvarArquivo.FileName = "Imagem";
            }
            else
            {
                SalvarArquivo.FileName = txtNome.Text;
            }

            SalvarArquivo.Title = "Escolha aonde vai salvar sua imagem";
            SalvarArquivo.ShowDialog();
        }
        #endregion

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            #region Mantem as labels de tamanho no centro
            TelaTamanho.Location = new Point(Size.Width / 2 - TelaTamanho.Size.Width / 2,TelaTamanho.Location.Y);

            //                               distancia da tela          tamanho da tela / 2        tamanho label / 2           altura normal
            lblSuperior.Location = new Point(TelaTamanho.Location.X + TelaTamanho.Size.Width / 2 - lblSuperior.Size.Width / 2, lblSuperior.Location.Y);
            lblInferior.Location = new Point(TelaTamanho.Location.X + TelaTamanho.Size.Width / 2 - lblInferior.Size.Width / 2, lblInferior.Location.Y);

            lblEsquerda.Location = new Point(lblEsquerda.Location.X, TelaTamanho.Location.Y + TelaTamanho.Size.Height / 2 - lblEsquerda.Size.Width / 2);

            #endregion
        }
    }
}
