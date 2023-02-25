namespace ProyectoEscuelaPlatzi.Entidades
{
    public class Evaluaciones
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public Alumno alumno { get; set; }
        public Asignatura asignatura { get; set; }
        public float Nota { get; set; }

        public Evaluaciones() => UniqueId = Guid.NewGuid().ToString();
    }
}