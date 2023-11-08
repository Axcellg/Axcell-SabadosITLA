/// <summary>
/// Objeto creado para el acceso a los datos del formulario de Empleados.
/// </summary>

namespace FormsEmpleados.Class
{
    internal class Acceso_a_datos
    {
        private List<Negocios> negocios;

        public Acceso_a_datos()
        {
            this.negocios = new List<Negocios>();

        }

        /// <summary>
        /// Metodo Para guardar a los empleados 
        /// </summary>
        /// <param name="negocios">Empleado que desea guardar </param>

        public void Guardar(Negocios negocios)
        {
            if (negocios == null)
                throw new ArgumentNullException("El empleado es requerido para ejecutar este metodo.");


            this.negocios.Add(negocios);
        }

        /// <summary>
        /// Metodo para obtener todos los Empleados
        /// </summary>
        /// <returns>Retorna una lista de los Empleados</returns>

        public List<Negocios> GetNegocios()
        {
            return this.negocios;
        }

        /// <summary>
        /// Obtener el detalle del empleado por la fecha de Contratacion
        /// </summary>
        /// <param name="fechaContr">fecha de Contratacion del Empleado</param>
        /// <returns>Empleado encontrado a partir de la fecha de Contratacion</returns>
        public Negocios GetNegocios(DateTime fechaContr)
        {
            Negocios negocios = this.negocios.FirstOrDefault(co => co.fechaContratacion == fechaContr);
            return negocios;
        }

        /// <summary>
        /// Metodo para obtener el detalle del empleado a partir del codigo.
        /// </summary>
        /// <param name="codigo">codigo del empleado que desea ver el detalle</param>
        /// <returns>Empleado encontrado a partir del codigo.</returns>

        public Negocios GetNegocios(string codigo)
        {
            return this.negocios.FirstOrDefault(co => co.Codigo == codigo);

        }
    }
}
