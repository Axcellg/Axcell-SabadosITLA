namespace FormsEmpleados.Class
{
    public class Negocios
    {
        #region "atributos o campos de nuestra clase"

        private string? _Nombres;
        private string? _Apellidos;
        private string? _CorreElectronico;
        private string? _telefono;
        private string? _Direccion;
        private string? _Posicion;
        private string? _Departamento;
        private DateTime _fechaContratacion;

        #endregion

        #region ¨Propiedades¨

        /// <summary>
        /// Codigo de Empleado
        /// </summary>
        public string? Codigo { get; set; }

        /// <summary>
        /// Esta propiedad es para almacenar el Nombre del Empleado.
        /// </summary>
        public string Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }
        /// <summary>
        /// Esta propiedad es para almancer los apellidos del Empleado.
        /// </summary>
        public string Apellido
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

        /// <summary>
        /// Correo electronico del Empleado. 
        /// </summary>
        public string CorreoElectronico
        {
            get { return _CorreElectronico; }
            set { _CorreElectronico = value; }

        }

        /// <summary>
        /// El telefono del Empleado
        /// </summary>
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        /// <summary>
        /// Direccion del Empleado.
        /// </summary>
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        /// <summary>
        /// Posicion del Empleado.
        /// </summary>
        public string Posicion
        {
            get { return _Posicion; }
            set { _Posicion = value; }
        }
        /// <summary>
        /// Departamento del Empleado.
        /// </summary>
        public string Departamento
        {
            get { return _Departamento; }
            set { _Departamento = value; }
        }

        /// <summary>
        /// fecha de Contratacion del empleado.
        /// </summary>
        public DateTime fechaContratacion
        {
            get { return _fechaContratacion; }
            set { _fechaContratacion = value; }
        }

        public string NombreCompleto
        {

            get { return string.Concat(this._Nombres, "", this._Apellidos); }

        }

        #endregion

    }
}
