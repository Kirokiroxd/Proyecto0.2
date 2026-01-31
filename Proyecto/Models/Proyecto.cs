namespace Proyecto.Models
{
    public class Proyecto
    {
        public int ProyectoId { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public ICollection<Asignacion> Asignaciones { get; set; }
    }

}
