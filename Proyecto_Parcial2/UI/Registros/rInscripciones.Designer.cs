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
            this.DescripcionAsignaturatextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BuscarAsignaturabutton = new System.Windows.Forms.Button();
            this.IdAsignaturanumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.AsignaturasdataGridView = new System.Windows.Forms.DataGridView();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.EliminarFilabutton = new System.Windows.Forms.Button();
            this.PrecioCreditosnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdInscripcionnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdEstudiantenumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdAsignaturanumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturasdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioCreditosnumericUpDown)).BeginInit();
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
            this.BuscarInscripcionbutton.Location = new System.Drawing.Point(237, 41);
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
            this.IdInscripcionnumericUpDown.Location = new System.Drawing.Point(101, 47);
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
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inscripcion Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Estudiante Id:";
            // 
            // IdEstudiantenumericUpDown
            // 
            this.IdEstudiantenumericUpDown.Location = new System.Drawing.Point(101, 85);
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
            this.BuscarEstudiantebutton.Location = new System.Drawing.Point(237, 79);
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
            this.label3.Location = new System.Drawing.Point(22, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre del Estudiante:";
            // 
            // EstudianteNombretextBox
            // 
            this.EstudianteNombretextBox.Location = new System.Drawing.Point(145, 121);
            this.EstudianteNombretextBox.Name = "EstudianteNombretextBox";
            this.EstudianteNombretextBox.ReadOnly = true;
            this.EstudianteNombretextBox.Size = new System.Drawing.Size(219, 20);
            this.EstudianteNombretextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Facha: ";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(74, 157);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(171, 20);
            this.FechadateTimePicker.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescripcionAsignaturatextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BuscarAsignaturabutton);
            this.groupBox1.Controls.Add(this.IdAsignaturanumericUpDown);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AsignaturasdataGridView);
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Location = new System.Drawing.Point(13, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 233);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignaturas";
            // 
            // DescripcionAsignaturatextBox
            // 
            this.DescripcionAsignaturatextBox.Location = new System.Drawing.Point(182, 18);
            this.DescripcionAsignaturatextBox.Name = "DescripcionAsignaturatextBox";
            this.DescripcionAsignaturatextBox.ReadOnly = true;
            this.DescripcionAsignaturatextBox.Size = new System.Drawing.Size(136, 20);
            this.DescripcionAsignaturatextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descripcion:";
            // 
            // BuscarAsignaturabutton
            // 
            this.BuscarAsignaturabutton.Image = global::Proyecto_Parcial2.Properties.Resources.buscaTyni;
            this.BuscarAsignaturabutton.Location = new System.Drawing.Point(77, 17);
            this.BuscarAsignaturabutton.Name = "BuscarAsignaturabutton";
            this.BuscarAsignaturabutton.Size = new System.Drawing.Size(30, 23);
            this.BuscarAsignaturabutton.TabIndex = 8;
            this.BuscarAsignaturabutton.UseVisualStyleBackColor = true;
            this.BuscarAsignaturabutton.Click += new System.EventHandler(this.BuscarAsignaturabutton_Click);
            // 
            // IdAsignaturanumericUpDown
            // 
            this.IdAsignaturanumericUpDown.Location = new System.Drawing.Point(16, 18);
            this.IdAsignaturanumericUpDown.Name = "IdAsignaturanumericUpDown";
            this.IdAsignaturanumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.IdAsignaturanumericUpDown.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Id:";
            // 
            // AsignaturasdataGridView
            // 
            this.AsignaturasdataGridView.AllowUserToAddRows = false;
            this.AsignaturasdataGridView.AllowUserToDeleteRows = false;
            this.AsignaturasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsignaturasdataGridView.Location = new System.Drawing.Point(6, 53);
            this.AsignaturasdataGridView.Name = "AsignaturasdataGridView";
            this.AsignaturasdataGridView.ReadOnly = true;
            this.AsignaturasdataGridView.Size = new System.Drawing.Size(358, 174);
            this.AsignaturasdataGridView.TabIndex = 5;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Image = global::Proyecto_Parcial2.Properties.Resources.add;
            this.Agregarbutton.Location = new System.Drawing.Point(324, 11);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(40, 36);
            this.Agregarbutton.TabIndex = 4;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total:";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(277, 455);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.TotaltextBox.TabIndex = 19;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Proyecto_Parcial2.Properties.Resources.nuevo;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(44, 501);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 53);
            this.Nuevobutton.TabIndex = 20;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Proyecto_Parcial2.Properties.Resources.guardar;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(156, 501);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 53);
            this.Guardarbutton.TabIndex = 21;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Proyecto_Parcial2.Properties.Resources.eliminar;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(267, 501);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 53);
            this.Eliminarbutton.TabIndex = 22;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // EliminarFilabutton
            // 
            this.EliminarFilabutton.Image = global::Proyecto_Parcial2.Properties.Resources.remover;
            this.EliminarFilabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarFilabutton.Location = new System.Drawing.Point(19, 451);
            this.EliminarFilabutton.Name = "EliminarFilabutton";
            this.EliminarFilabutton.Size = new System.Drawing.Size(101, 32);
            this.EliminarFilabutton.TabIndex = 23;
            this.EliminarFilabutton.Text = "Eliminar Fila";
            this.EliminarFilabutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarFilabutton.UseVisualStyleBackColor = true;
            this.EliminarFilabutton.Click += new System.EventHandler(this.EliminarFilabutton_Click);
            // 
            // PrecioCreditosnumericUpDown
            // 
            this.PrecioCreditosnumericUpDown.DecimalPlaces = 2;
            this.PrecioCreditosnumericUpDown.Location = new System.Drawing.Point(129, 191);
            this.PrecioCreditosnumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.PrecioCreditosnumericUpDown.Name = "PrecioCreditosnumericUpDown";
            this.PrecioCreditosnumericUpDown.Size = new System.Drawing.Size(142, 20);
            this.PrecioCreditosnumericUpDown.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Precio de Creditos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "Inscripciones";
            // 
            // rInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 573);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PrecioCreditosnumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EliminarFilabutton);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rInscripciones";
            this.Text = "Registro de Inscripciones";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdInscripcionnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdEstudiantenumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdAsignaturanumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturasdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioCreditosnumericUpDown)).EndInit();
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
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView AsignaturasdataGridView;
        private System.Windows.Forms.Button EliminarFilabutton;
        private System.Windows.Forms.TextBox DescripcionAsignaturatextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BuscarAsignaturabutton;
        private System.Windows.Forms.NumericUpDown IdAsignaturanumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown PrecioCreditosnumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}