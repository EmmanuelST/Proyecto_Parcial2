namespace Proyecto_Parcial2
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeAsignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeEstudiantesToolStripMenuItem,
            this.registroDeAsignaturasToolStripMenuItem,
            this.inscripcionesToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "&Registros";
            // 
            // registroDeEstudiantesToolStripMenuItem
            // 
            this.registroDeEstudiantesToolStripMenuItem.Name = "registroDeEstudiantesToolStripMenuItem";
            this.registroDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.registroDeEstudiantesToolStripMenuItem.Text = "Registro de &Estudiantes";
            this.registroDeEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeEstudiantesToolStripMenuItem_Click);
            // 
            // registroDeAsignaturasToolStripMenuItem
            // 
            this.registroDeAsignaturasToolStripMenuItem.Name = "registroDeAsignaturasToolStripMenuItem";
            this.registroDeAsignaturasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.registroDeAsignaturasToolStripMenuItem.Text = "Registro de &Asignaturas";
            this.registroDeAsignaturasToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeAsignaturasToolStripMenuItem_Click);
            // 
            // inscripcionesToolStripMenuItem
            // 
            this.inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            this.inscripcionesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.inscripcionesToolStripMenuItem.Text = "&Inscripciones";
            this.inscripcionesToolStripMenuItem.Click += new System.EventHandler(this.InscripcionesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 617);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(942, 656);
            this.Name = "MainForm";
            this.Text = "Manejo de Estudiantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeAsignaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem;
    }
}

