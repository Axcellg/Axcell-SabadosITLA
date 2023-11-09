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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Negocios negocios = new Negocios()
            {

                Nombres = tbxNombre.Text,
                Apellido = tbxApellido.Text,
                CorreoElectronico = tbxCorreoElectronico.Text,
                Telefono = tbxTelefono.Text,
                Direccion = tbxDireccion.Text,
                Posicion = tbxPosicion.Text,
                Departamento = tbxDepartamento.Text,
                Codigo = tbxCodigo.Text,

            };

            this.Acceso_A_Datos.Guardar(negocios);
            var negocios1 = this.Acceso_A_Datos.GetNegocios();

        }


    }
}