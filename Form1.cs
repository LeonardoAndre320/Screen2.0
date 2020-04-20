﻿using System;
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
            TelaTamanho.Location = new Point(Size.Width / 2 - TelaTamanho.Size.Width / 2, TelaTamanho.Location.Y);//Centraliza a tela de tamanho

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

            SalvarArquivo.Filter = "Arquivos de imagens|*.bmp;*.icon;*.jpeg;*.png|Todos os arquivos|*.*";
            SalvarArquivo.Title = "Escolha aonde vai salvar sua imagem";
            SalvarArquivo.ShowDialog();
        }
        #endregion

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            #region Mantem as labels de tamanho no centro

            //                               distancia da tela          tamanho da tela / 2        tamanho label / 2           altura normal
            lblSuperior.Location = new Point(TelaTamanho.Location.X + TelaTamanho.Size.Width / 2 - lblSuperior.Size.Width / 2, lblSuperior.Location.Y);
            lblInferior.Location = new Point(TelaTamanho.Location.X + TelaTamanho.Size.Width / 2 - lblInferior.Size.Width / 2, lblInferior.Location.Y);

            lblEsquerda.Location = new Point(TelaTamanho.Location.X - lblEsquerda.Size.Width,TelaTamanho.Location.Y + TelaTamanho.Size.Height / 2 - lblEsquerda.Size.Height / 2);
            lblDireita.Location = new Point(TelaTamanho.Location.X + 96 , TelaTamanho.Location.Y + TelaTamanho.Size.Height / 2 - lblDireita.Size.Height / 2);
            
            #endregion

        }

        private Bitmap CortarImagem(Bitmap Imagem, int Superior = 0, int Inferior = 0, int Esquerda = 0, int Direita = 0)
        {


            return Imagem;
        }

        int CorteSelecionado = 0;
        
        private void ClickSuperior(object sender, EventArgs e)
        {
            
            if (CorteSelecionado != 0)
            {
                lblSuperior.ForeColor = Color.SteelBlue;
                CorteSelecionado = 0;
            }
            else
            {
                lblSuperior.ForeColor = Color.White;
                CorteSelecionado = 0;
            }
            
        }

        private void MudarValor2(object sender,EventArgs e)
        {
        }
    }
}
