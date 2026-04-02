namespace Cálculo_de_Nómina
{
    // CLASE CONCRETA: Hereda de Empleado (clase abstracta)
    public class EmpleadoPorHoras : Empleado
    {
        public int HorasTrabajadas { get; set; }
        public double PagoPorHora { get; set; }

        public EmpleadoPorHoras(string id, string nombre, int horas, double pagoPorHora)
            : base(id, nombre)
        {
            HorasTrabajadas = horas;
            PagoPorHora = pagoPorHora;
        }

        // Implementación obligatoria del método abstracto
        public override double CalcularSueldo()
        {
            return HorasTrabajadas * PagoPorHora;
        }

        public override string TipoEmpleado => "Por Horas";

        public override string ObtenerInforme()
        {
            return $"[POR HORAS] {Id} | {Nombre} | {HorasTrabajadas}h × {PagoPorHora:C2} = {CalcularSueldo():C2}";
        }
    }
}