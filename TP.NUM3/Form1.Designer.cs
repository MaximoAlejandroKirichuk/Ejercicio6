namespace TP.NUM3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bandoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bandoJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.juegoToolStripMenuItem,
            this.jugadorToolStripMenuItem,
            this.bandoToolStripMenuItem,
            this.bandoJugadorToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // juegoToolStripMenuItem
            // 
            this.juegoToolStripMenuItem.Name = "juegoToolStripMenuItem";
            this.juegoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.juegoToolStripMenuItem.Text = "Juego";
            this.juegoToolStripMenuItem.Click += new System.EventHandler(this.juegoToolStripMenuItem_Click);
            // 
            // jugadorToolStripMenuItem
            // 
            this.jugadorToolStripMenuItem.Name = "jugadorToolStripMenuItem";
            this.jugadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jugadorToolStripMenuItem.Text = "Jugador";
            this.jugadorToolStripMenuItem.Click += new System.EventHandler(this.jugadorToolStripMenuItem_Click);
            // 
            // bandoToolStripMenuItem
            // 
            this.bandoToolStripMenuItem.Name = "bandoToolStripMenuItem";
            this.bandoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bandoToolStripMenuItem.Text = "Bando";
            this.bandoToolStripMenuItem.Click += new System.EventHandler(this.bandoToolStripMenuItem_Click);
            // 
            // bandoJugadorToolStripMenuItem
            // 
            this.bandoJugadorToolStripMenuItem.Name = "bandoJugadorToolStripMenuItem";
            this.bandoJugadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bandoJugadorToolStripMenuItem.Text = "BandoJugador";
            this.bandoJugadorToolStripMenuItem.Click += new System.EventHandler(this.bandoJugadorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bandoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bandoJugadorToolStripMenuItem;
    }
}

