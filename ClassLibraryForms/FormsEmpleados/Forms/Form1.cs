using FormsEmpleados.Class;

namespace FormsEmpleados
{
    public partial class FormEmpleado : Form
    {
        Acceso_a_datos Acceso_A_Datos;
        public FormEmpleado()
        {
            this.Acceso_A_Datos = new Acceso_a_datos();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Negocios newnegocios = new Negocios()
            {

                Nombres = tbxNombre.Text,
                Apellido = tbxApellido.Text,
                CorreoElectronico = tbxCorreoElectronico.Text,
                Telefono = tbxTelefono.Text,
                Direccion = tbxDireccion.Text,
                Posicion = tbxPosicion.Text,
                Departamento = tbxDepartamento.Text,
                Codigo = tbxCodigo.Text,
                fechaContratacion = dtpFechaCon.Value,

            };

            this.Acceso_A_Datos.Guardar(newnegocios);
            var negocios1 = this.Acceso_A_Datos.GetNegocios();

            this.dgvEmpleados.DataSource = negocios1.ToArray();
            this.dgvEmpleados.Refresh();
            LimpiarCampos();

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

            LimpiarCampos();

        }
        void LimpiarCampos()
        {
            tbxNombre.Text = string.Empty;
            tbxApellido.Text = string.Empty;
            tbxCorreoElectronico.Text = string.Empty;
            dtpFechaCon.Value = DateTime.Now;
            tbxDepartamento.Text = string.Empty;
            tbxDireccion.Text = string.Empty;
            tbxCodigo.Text = string.Empty;
            tbxPosicion.Text = string.Empty;
            tbxTelefono.Text = string.Empty;
            tbxCodigo.Focus();

    }
    }
}