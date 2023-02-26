namespace ProyectoEscuelaPlatzi.Entidades
{
    public class Alumno
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public List<Asignatura> Asignaturas { get; set; }

        public Alumno(string nombre)
        {
            UniqueId = Guid.NewGuid().ToString();
            Nombre = nombre;
            Asignaturas = InicializarAsignaturas();
        }

        private List<Asignatura> InicializarAsignaturas()
        {
            Evaluaciones evaluaciones = new Evaluaciones();
            List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura("Matemáticas", evaluaciones.GenerarNotas()),
                    new Asignatura("Castellano", evaluaciones.GenerarNotas()),
                    new Asignatura("Física", evaluaciones.GenerarNotas()),
                    new Asignatura("Química", evaluaciones.GenerarNotas()),
                    new Asignatura("Economía", evaluaciones.GenerarNotas())
                };
            return listaAsignaturas;
        }
    }
}