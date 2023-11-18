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
            DatosdelEmpeado = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            dgvEmpleados = new DataGridView();
            gbDatosEmpleados = new GroupBox();
            tbxCodigo = new TextBox();
            label10 = new Label();
            dtpFechaCon = new DateTimePicker();
            tbxDepartamento = new TextBox();
            tbxPosicion = new TextBox();
            tbxDireccion = new TextBox();
            tbxTelefono = new TextBox();
            tbxCorreoElectronico = new TextBox();
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
            // DatosdelEmpeado
            // 
            DatosdelEmpeado.AutoSize = true;
            DatosdelEmpeado.BorderStyle = BorderStyle.FixedSingle;
            DatosdelEmpeado.Font = new Font("Sitka Small", 22F, FontStyle.Bold, GraphicsUnit.Point);
            DatosdelEmpeado.ForeColor = Color.DarkGreen;
            DatosdelEmpeado.Location = new Point(259, 21);
            DatosdelEmpeado.Name = "DatosdelEmpeado";
            DatosdelEmpeado.Size = new Size(348, 46);
            DatosdelEmpeado.TabIndex = 40;
            DatosdelEmpeado.Text = "Datos del Empleado ";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardar.Location = new Point(565, 385);
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
            btnCancelar.Location = new Point(699, 385);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 34);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(22, 434);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowTemplate.Height = 25;
            dgvEmpleados.Size = new Size(785, 244);
            dgvEmpleados.TabIndex = 43;
            // 
            // gbDatosEmpleados
            // 
            gbDatosEmpleados.Controls.Add(tbxCodigo);
            gbDatosEmpleados.Controls.Add(label10);
            gbDatosEmpleados.Controls.Add(dtpFechaCon);
            gbDatosEmpleados.Controls.Add(tbxDepartamento);
            gbDatosEmpleados.Controls.Add(tbxPosicion);
            gbDatosEmpleados.Controls.Add(tbxDireccion);
            gbDatosEmpleados.Controls.Add(tbxTelefono);
            gbDatosEmpleados.Controls.Add(tbxCorreoElectronico);
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
            gbDatosEmpleados.Size = new Size(799, 296);
            gbDatosEmpleados.TabIndex = 44;
            gbDatosEmpleados.TabStop = false;
            gbDatosEmpleados.Text = "Datos Empleado";
            // 
            // tbxCodigo
            // 
            tbxCodigo.Location = new Point(171, 57);
            tbxCodigo.Name = "tbxCodigo";
            tbxCodigo.Size = new Size(195, 22);
            tbxCodigo.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Small", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(86, 59);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 45;
            label10.Text = "Codigo:";
            // 
            // dtpFechaCon
            // 
            dtpFechaCon.Location = new Point(581, 177);
            dtpFechaCon.Name = "dtpFechaCon";
            dtpFechaCon.Size = new Size(212, 22);
            dtpFechaCon.TabIndex = 44;
            // 
            // tbxDepartamento
            // 
            tbxDepartamento.Location = new Point(581, 139);
            tbxDepartamento.Name = "tbxDepartamento";
            tbxDepartamento.Size = new Size(212, 22);
            tbxDepartamento.TabIndex = 43;
            // 
            // tbxPosicion
            // 
            tbxPosicion.Location = new Point(581, 98);
            tbxPosicion.Name = "tbxPosicion";
            tbxPosicion.Size = new Size(212, 22);
            tbxPosicion.TabIndex = 42;
            // 
            // tbxDireccion
            // 
            tbxDireccion.Location = new Point(581, 57);
            tbxDireccion.Name = "tbxDireccion";
            tbxDireccion.Size = new Size(212, 22);
            tbxDireccion.TabIndex = 41;
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(171, 226);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(195, 22);
            tbxTelefono.TabIndex = 40;
            // 
            // tbxCorreoElectronico
            // 
            tbxCorreoElectronico.Location = new Point(171, 178);
            tbxCorreoElectronico.Name = "tbxCorreoElectronico";
            tbxCorreoElectronico.Size = new Size(195, 22);
            tbxCorreoElectronico.TabIndex = 39;
            // 
            // tbxApellido
            // 
            tbxApellido.Location = new Point(171, 134);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.Size = new Size(195, 22);
            tbxApellido.TabIndex = 38;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(171, 91);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(195, 22);
            tbxNombre.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(462, 100);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 36;
            label8.Text = "Posicion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(431, 141);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 35;
            label7.Text = "Departamento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(406, 180);
            label6.Name = "label6";
            label6.Size = new Size(159, 20);
            label6.TabIndex = 34;
            label6.Text = "Fecha Contratacion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(69, 228);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 33;
            label5.Text = "Telefono :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(457, 57);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 32;
            label4.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 180);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 31;
            label3.Text = "Correo Electronico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(77, 136);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 30;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 93);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 29;
            label1.Text = "Nombres:";
            // 
            // FormEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(835, 701);
            Controls.Add(gbDatosEmpleados);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(DatosdelEmpeado);
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
        private TextBox tbxCorreoElectronico;
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
        private TextBox tbxCodigo;
        private Label label10;
        private Label DatosdelEmpeado;
    }
}