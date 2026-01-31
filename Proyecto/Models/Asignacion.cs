namespace Proyecto.Models
{
    public class Asignacion
    {
        public int ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; }

        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

        public string RolEnProyecto { get; set; }
        public DateTime FechaAsignacion { get; set; }
    }

}
