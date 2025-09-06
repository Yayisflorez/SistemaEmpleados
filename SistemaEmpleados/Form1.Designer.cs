namespace SistemaEmpleados
{
    partial class SitemaEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SitemaEmpleados));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblMensajeEmple = new System.Windows.Forms.Label();
            this.btnCalcularEdad = new System.Windows.Forms.Button();
            this.txtCalcularEdad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalcularAntiguedad = new System.Windows.Forms.Button();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.lblMensajeEmple);
            this.groupBox1.Controls.Add(this.txtFechaIngreso);
            this.groupBox1.Controls.Add(this.txtFechaNacimiento);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.txtGenero);
            this.groupBox1.Controls.Add(this.txtSalario);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Size = new System.Drawing.Size(545, 367);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::SistemaEmpleados.Properties.Resources.mujer;
            this.pictureBox1.Location = new System.Drawing.Point(367, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(376, 210);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 45);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFechaIngreso.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaIngreso.Location = new System.Drawing.Point(221, 221);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(118, 33);
            this.txtFechaIngreso.TabIndex = 10;
            this.txtFechaIngreso.TextChanged += new System.EventHandler(this.txtFechaIngreso_TextChanged);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.Location = new System.Drawing.Point(220, 173);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(119, 33);
            this.txtFechaNacimiento.TabIndex = 9;
            // 
            // txtGenero
            // 
            this.txtGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtGenero.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(124, 132);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(125, 33);
            this.txtGenero.TabIndex = 8;
            this.txtGenero.TextChanged += new System.EventHandler(this.txtGenero_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtApellido.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(124, 91);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 29);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNombre.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(124, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 29);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de ingreso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Genero:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 35);
            this.label6.TabIndex = 3;
            this.label6.Text = "Salario:  $";
            // 
            // txtSalario
            // 
            this.txtSalario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSalario.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(138, 275);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(178, 31);
            this.txtSalario.TabIndex = 4;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(320, 272);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 45);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblMensajeEmple
            // 
            this.lblMensajeEmple.AutoSize = true;
            this.lblMensajeEmple.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeEmple.Location = new System.Drawing.Point(39, 317);
            this.lblMensajeEmple.Name = "lblMensajeEmple";
            this.lblMensajeEmple.Size = new System.Drawing.Size(0, 28);
            this.lblMensajeEmple.TabIndex = 7;
            // 
            // btnCalcularEdad
            // 
            this.btnCalcularEdad.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCalcularEdad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularEdad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularEdad.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularEdad.Location = new System.Drawing.Point(41, 405);
            this.btnCalcularEdad.Name = "btnCalcularEdad";
            this.btnCalcularEdad.Size = new System.Drawing.Size(134, 45);
            this.btnCalcularEdad.TabIndex = 8;
            this.btnCalcularEdad.Text = "Calcular edad";
            this.btnCalcularEdad.UseVisualStyleBackColor = false;
            this.btnCalcularEdad.Click += new System.EventHandler(this.btnCalcularEdad_Click);
            // 
            // txtCalcularEdad
            // 
            this.txtCalcularEdad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCalcularEdad.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalcularEdad.Location = new System.Drawing.Point(190, 416);
            this.txtCalcularEdad.Name = "txtCalcularEdad";
            this.txtCalcularEdad.Size = new System.Drawing.Size(110, 34);
            this.txtCalcularEdad.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(362, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fotografia:";
            // 
            // btnCalcularAntiguedad
            // 
            this.btnCalcularAntiguedad.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCalcularAntiguedad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularAntiguedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularAntiguedad.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularAntiguedad.Location = new System.Drawing.Point(41, 463);
            this.btnCalcularAntiguedad.Name = "btnCalcularAntiguedad";
            this.btnCalcularAntiguedad.Size = new System.Drawing.Size(205, 45);
            this.btnCalcularAntiguedad.TabIndex = 10;
            this.btnCalcularAntiguedad.Text = "Calcular antigüedad";
            this.btnCalcularAntiguedad.UseVisualStyleBackColor = false;
            this.btnCalcularAntiguedad.Click += new System.EventHandler(this.btnCalcularAntiguedad_Click);
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAntiguedad.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAntiguedad.Location = new System.Drawing.Point(266, 474);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(161, 34);
            this.txtAntiguedad.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Sitka Display Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(433, 387);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 52);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Sitka Display Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(433, 456);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 52);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // SitemaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(568, 538);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.btnCalcularAntiguedad);
            this.Controls.Add(this.txtCalcularEdad);
            this.Controls.Add(this.btnCalcularEdad);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "SitemaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Sistema de empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblMensajeEmple;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCalcularEdad;
        private System.Windows.Forms.TextBox txtCalcularEdad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalcularAntiguedad;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

