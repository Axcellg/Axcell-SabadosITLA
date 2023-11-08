namespace FormsEmpleados
{
    partial class FormEmpleado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label9 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            dgvEmpleados = new DataGridView();
            gbDatosEmpleados = new GroupBox();
            dtpFechaCon = new DateTimePicker();
            tbxDepartamento = new TextBox();
            tbxPosicion = new TextBox();
            tbxDireccion = new TextBox();
            tbxTelefono = new TextBox();
            tbxCorreo = new TextBox();
            tbxApellido = new TextBox();
            tbxNombre = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            gbDatosEmpleados.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Sitka Small", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkGreen;
            label9.Location = new Point(259, 21);
            label9.Name = "label9";
            label9.Size = new Size(348, 46);
            label9.TabIndex = 40;
            label9.Text = "Datos del Empleado ";
            label9.Click += label9_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardar.Location = new Point(234, 333);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(104, 34);
            btnGuardar.TabIndex = 41;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(529, 333);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 34);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(24, 383);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowTemplate.Height = 25;
            dgvEmpleados.Size = new Size(785, 244);
            dgvEmpleados.TabIndex = 43;
            // 
            // gbDatosEmpleados
            // 
            gbDatosEmpleados.Controls.Add(dtpFechaCon);
            gbDatosEmpleados.Controls.Add(tbxDepartamento);
            gbDatosEmpleados.Controls.Add(tbxPosicion);
            gbDatosEmpleados.Controls.Add(tbxDireccion);
            gbDatosEmpleados.Controls.Add(tbxTelefono);
            gbDatosEmpleados.Controls.Add(tbxCorreo);
            gbDatosEmpleados.Controls.Add(tbxApellido);
            gbDatosEmpleados.Controls.Add(tbxNombre);
            gbDatosEmpleados.Controls.Add(label8);
            gbDatosEmpleados.Controls.Add(label7);
            gbDatosEmpleados.Controls.Add(label6);
            gbDatosEmpleados.Controls.Add(label5);
            gbDatosEmpleados.Controls.Add(label4);
            gbDatosEmpleados.Controls.Add(label3);
            gbDatosEmpleados.Controls.Add(label2);
            gbDatosEmpleados.Controls.Add(label1);
            gbDatosEmpleados.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbDatosEmpleados.Location = new Point(24, 83);
            gbDatosEmpleados.Name = "gbDatosEmpleados";
            gbDatosEmpleados.Size = new Size(779, 231);
            gbDatosEmpleados.TabIndex = 44;
            gbDatosEmpleados.TabStop = false;
            gbDatosEmpleados.Text = "Datos Empleado";
            // 
            // dtpFechaCon
            // 
            dtpFechaCon.Location = new Point(558, 186);
            dtpFechaCon.Name = "dtpFechaCon";
            dtpFechaCon.Size = new Size(212, 22);
            dtpFechaCon.TabIndex = 44;
            // 
            // tbxDepartamento
            // 
            tbxDepartamento.Location = new Point(558, 136);
            tbxDepartamento.Name = "tbxDepartamento";
            tbxDepartamento.Size = new Size(212, 22);
            tbxDepartamento.TabIndex = 43;
            // 
            // tbxPosicion
            // 
            tbxPosicion.Location = new Point(558, 97);
            tbxPosicion.Name = "tbxPosicion";
            tbxPosicion.Size = new Size(212, 22);
            tbxPosicion.TabIndex = 42;
            // 
            // tbxDireccion
            // 
            tbxDireccion.Location = new Point(558, 52);
            tbxDireccion.Name = "tbxDireccion";
            tbxDireccion.Size = new Size(212, 22);
            tbxDireccion.TabIndex = 41;
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(138, 191);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(195, 22);
            tbxTelefono.TabIndex = 40;
            // 
            // tbxCorreo
            // 
            tbxCorreo.Location = new Point(138, 143);
            tbxCorreo.Name = "tbxCorreo";
            tbxCorreo.Size = new Size(195, 22);
            tbxCorreo.TabIndex = 39;
            // 
            // tbxApellido
            // 
            tbxApellido.Location = new Point(138, 99);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.Size = new Size(195, 22);
            tbxApellido.TabIndex = 38;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(138, 56);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(195, 22);
            tbxNombre.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(459, 100);
            label8.Name = "label8";
            label8.Size = new Size(68, 18);
            label8.TabIndex = 36;
            label8.Text = "Posicion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(428, 141);
            label7.Name = "label7";
            label7.Size = new Size(102, 18);
            label7.TabIndex = 35;
            label7.Text = "Departamento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(401, 192);
            label6.Name = "label6";
            label6.Size = new Size(134, 18);
            label6.TabIndex = 34;
            label6.Text = "Fecha Contratacion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 195);
            label5.Name = "label5";
            label5.Size = new Size(72, 18);
            label5.TabIndex = 33;
            label5.Text = "Telefono :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 57);
            label4.Name = "label4";
            label4.Size = new Size(73, 18);
            label4.TabIndex = 32;
            label4.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-2, 147);
            label3.Name = "label3";
            label3.Size = new Size(133, 18);
            label3.TabIndex = 31;
            label3.Text = "Correo Electronico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 103);
            label2.Name = "label2";
            label2.Size = new Size(68, 18);
            label2.TabIndex = 30;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 60);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 29;
            label1.Text = "Nombres:";
            // 
            // FormEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(835, 652);
            Controls.Add(gbDatosEmpleados);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label9);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormEmpleado";
            Text = "FormEmpleado";
            Load += FormEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            gbDatosEmpleados.ResumeLayout(false);
            gbDatosEmpleados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Button btnGuardar;
        private Button btnCancelar;
        private DataGridView dgvEmpleados;
        private GroupBox gbDatosEmpleados;
        private DateTimePicker dtpFechaCon;
        private TextBox tbxDepartamento;
        private TextBox tbxPosicion;
        private TextBox tbxDireccion;
        private TextBox tbxTelefono;
        private TextBox tbxCorreo;
        private TextBox tbxApellido;
        private TextBox tbxNombre;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}