namespace Cálculo_de_Nómina
{
    // CLASE ABSTRACTA BASE
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Id { get; set; }

        public Empleado(string id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        // Método abstracto obligatorio en subclases
        public abstract double CalcularSueldo();

        // Método virtual que puede sobreescribirse
        public virtual string ObtenerInforme()
        {
            return $"{Id} | {Nombre} → Sueldo: {CalcularSueldo():C2}";
        }

        public abstract string TipoEmpleado { get; }
    }
}