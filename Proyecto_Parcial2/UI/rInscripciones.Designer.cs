namespace Proyecto_Parcial2.UI
{
    partial class rInscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rInscripciones));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarInscripcionbutton = new System.Windows.Forms.Button();
            this.IdInscripcionnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdEstudiantenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuscarEstudiantebutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EstudianteNombretextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.AsignaturasdataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.AsiganaturascomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdInscripcionnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdEstudiantenumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // BuscarInscripcionbutton
            // 
            this.BuscarInscripcionbutton.Image = global::Proyecto_Parcial2.Properties.Resources.buscaTyni;
            this.BuscarInscripcionbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarInscripcionbutton.Location = new System.Drawing.Point(236, 18);
            this.BuscarInscripcionbutton.Name = "BuscarInscripcionbutton";
            this.BuscarInscripcionbutton.Size = new System.Drawing.Size(75, 32);
            this.BuscarInscripcionbutton.TabIndex = 9;
            this.BuscarInscripcionbutton.Text = "Buscar";
            this.BuscarInscripcionbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarInscripcionbutton.UseVisualStyleBackColor = true;
            this.BuscarInscripcionbutton.Click += new System.EventHandler(this.BuscarInscripcionbutton_Click);
            // 
            // IdInscripcionnumericUpDown
            // 
            this.IdInscripcionnumericUpDown.Location = new System.Drawing.Point(100, 24);
            this.IdInscripcionnumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.IdInscripcionnumericUpDown.Name = "IdInscripcionnumericUpDown";
            this.IdInscripcionnumericUpDown.Size = new System.Drawing.Size(130, 20);
            this.IdInscripcionnumericUpDown.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inscripcion Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Estudiante Id:";
            // 
            // IdEstudiantenumericUpDown
            // 
            this.IdEstudiantenumericUpDown.Location = new System.Drawing.Point(100, 62);
            this.IdEstudiantenumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.IdEstudiantenumericUpDown.Name = "IdEstudiantenumericUpDown";
            this.IdEstudiantenumericUpDown.Size = new System.Drawing.Size(130, 20);
            this.IdEstudiantenumericUpDown.TabIndex = 11;
            // 
            // BuscarEstudiantebutton
            // 
            this.BuscarEstudiantebutton.Image = global::Proyecto_Parcial2.Properties.Resources.buscaTyni;
            this.BuscarEstudiantebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarEstudiantebutton.Location = new System.Drawing.Point(236, 56);
            this.BuscarEstudiantebutton.Name = "BuscarEstudiantebutton";
            this.BuscarEstudiantebutton.Size = new System.Drawing.Size(75, 32);
            this.BuscarEstudiantebutton.TabIndex = 12;
            this.BuscarEstudiantebutton.Text = "Buscar";
            this.BuscarEstudiantebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarEstudiantebutton.UseVisualStyleBackColor = true;
            this.BuscarEstudiantebutton.Click += new System.EventHandler(this.BuscarEstudiantebutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre del Estudiante:";
            // 
            // EstudianteNombretextBox
            // 
            this.EstudianteNombretextBox.Location = new System.Drawing.Point(144, 98);
            this.EstudianteNombretextBox.Name = "EstudianteNombretextBox";
            this.EstudianteNombretextBox.Size = new System.Drawing.Size(219, 20);
            this.EstudianteNombretextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Facha: ";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(73, 134);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(171, 20);
            this.FechadateTimePicker.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AsiganaturascomboBox);
            this.groupBox1.Controls.Add(this.AsignaturasdataGridView);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 233);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignaturas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Asignatura:";
            // 
            // button2
            // 
            this.button2.Image = global::Proyecto_Parcial2.Properties.Resources.add;
            this.button2.Location = new System.Drawing.Point(297, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 36);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AsignaturasdataGridView
            // 
            this.AsignaturasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsignaturasdataGridView.Location = new System.Drawing.Point(6, 53);
            this.AsignaturasdataGridView.Name = "AsignaturasdataGridView";
            this.AsignaturasdataGridView.Size = new System.Drawing.Size(358, 174);
            this.AsignaturasdataGridView.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total:";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(276, 407);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.TotaltextBox.TabIndex = 19;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Proyecto_Parcial2.Properties.Resources.nuevo;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(27, 431);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 53);
            this.Nuevobutton.TabIndex = 20;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Proyecto_Parcial2.Properties.Resources.guardar;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(134, 431);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 53);
            this.Guardarbutton.TabIndex = 21;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Proyecto_Parcial2.Properties.Resources.eliminar;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(239, 431);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 53);
            this.Eliminarbutton.TabIndex = 22;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // AsiganaturascomboBox
            // 
            this.AsiganaturascomboBox.FormattingEnabled = true;
            this.AsiganaturascomboBox.Location = new System.Drawing.Point(73, 17);
            this.AsiganaturascomboBox.Name = "AsiganaturascomboBox";
            this.AsiganaturascomboBox.Size = new System.Drawing.Size(208, 21);
            this.AsiganaturascomboBox.TabIndex = 6;
            // 
            // rInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 503);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EstudianteNombretextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuscarEstudiantebutton);
            this.Controls.Add(this.IdEstudiantenumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarInscripcionbutton);
            this.Controls.Add(this.IdInscripcionnumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "rInscripciones";
            this.Text = "rInscripciones";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdInscripcionnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdEstudiantenumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturasdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox EstudianteNombretextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BuscarEstudiantebutton;
        private System.Windows.Forms.NumericUpDown IdEstudiantenumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarInscripcionbutton;
        private System.Windows.Forms.NumericUpDown IdInscripcionnumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView AsignaturasdataGridView;
        private System.Windows.Forms.ComboBox AsiganaturascomboBox;
    }
}