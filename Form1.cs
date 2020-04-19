using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen2._0
{
    public partial class TelaPrincipal : Form
    {

        int X = 0;
        int Y = 0;
        public TelaPrincipal()
        {

            InitializeComponent();

            Barra.MouseDown += new MouseEventHandler(MouseBaixo);
            Barra.MouseMove += new MouseEventHandler(MovimentoMouse);

            Titulo.MouseDown += new MouseEventHandler(MouseBaixo);
            Titulo.MouseMove += new MouseEventHandler(MovimentoMouse);
        }
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

        private void bntFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bntMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
