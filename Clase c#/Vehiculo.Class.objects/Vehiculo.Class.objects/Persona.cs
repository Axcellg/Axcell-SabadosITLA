namespace Persona.Class.objects
{
    public abstract class Persona
    {

        public string? Nombre { get; set; }
        public string? Apellido { get; set; }

        public string? Correo { get; set; }

        public string Direccion { get; set; }

        public int Telefono { get; set; }

        public abstract void Guardar();

        public abstract void Actualizar();

        public abstract void Remover();

    }
}
