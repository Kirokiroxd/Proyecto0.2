namespace Proyecto.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Posicion { get; set; }

        public ICollection<Asignacion> Asignaciones { get; set; }
    }

}
