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
            this.Titulo = new System.Windows.Forms.Label();
            this.Barra = new System.Windows.Forms.Panel();
            this.bntMinimizar = new System.Windows.Forms.PictureBox();
            this.bntFechar = new System.Windows.Forms.PictureBox();
            this.ImagensBotoes = new System.Windows.Forms.ImageList(this.components);
            this.Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntFechar)).BeginInit();
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
            this.bntMinimizar.BackColor = System.Drawing.Color.Blue;
            this.bntMinimizar.Location = new System.Drawing.Point(513, 0);
            this.bntMinimizar.Name = "bntMinimizar";
            this.bntMinimizar.Size = new System.Drawing.Size(30, 30);
            this.bntMinimizar.TabIndex = 2;
            this.bntMinimizar.TabStop = false;
            this.bntMinimizar.Click += new System.EventHandler(this.bntMinimizar_Click);
            // 
            // bntFechar
            // 
            this.bntFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntFechar.BackColor = System.Drawing.Color.Red;
            this.bntFechar.Location = new System.Drawing.Point(543, 0);
            this.bntFechar.Name = "bntFechar";
            this.bntFechar.Size = new System.Drawing.Size(30, 30);
            this.bntFechar.TabIndex = 1;
            this.bntFechar.TabStop = false;
            this.bntFechar.Click += new System.EventHandler(this.bntFechar_Click);
            // 
            // ImagensBotoes
            // 
            this.ImagensBotoes.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImagensBotoes.ImageSize = new System.Drawing.Size(16, 16);
            this.ImagensBotoes.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(573, 261);
            this.Controls.Add(this.Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Barra.ResumeLayout(false);
            this.Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Panel Barra;
        private System.Windows.Forms.PictureBox bntMinimizar;
        private System.Windows.Forms.PictureBox bntFechar;
        private System.Windows.Forms.ImageList ImagensBotoes;
    }
}

