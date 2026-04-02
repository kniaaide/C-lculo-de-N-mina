namespace Cálculo_de_Nómina
{
    // CLASE CONCRETA: Hereda de Empleado (clase abstracta)
    public class EmpleadoAsalariado : Empleado
    {
        public double SueldoMensual { get; set; }

        public EmpleadoAsalariado(string id, string nombre, double sueldoMensual)
            : base(id, nombre)
        {
            SueldoMensual = sueldoMensual;
        }

        // Implementación obligatoria del método abstracto
        public override double CalcularSueldo()
        {
            return SueldoMensual;
        }

        public override string TipoEmpleado => "Asalariado";

        public override string ObtenerInforme()
        {
            return $"[ASALARIADO] {Id} | {Nombre} | Sueldo Fijo: {SueldoMensual:C2}";
        }
    }
}