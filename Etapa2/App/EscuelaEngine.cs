namespace ProyectoEscuelaPlatzi.Entidades
{
    public class EscuelaEngine
    {
        public Escuela escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, "Chile", "Curacaví");
            CargarCursos();
        }

        private List<Alumno> CargarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Gever", "Laura", "Yudith", "José", "Christopher", "Carmen" };
            string[] nombre2 = { "Agustín", "Andreina", "Rebeca", "Javier", "Brian", "Elena" };
            string[] apellido1 = { "Rodríguez", "Peña", "Peralta", "Arias", "Colina", "Flores" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno($"{n1} {n2} {a1}");
            return listaAlumnos.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            escuela.Cursos = new List<Curso>(){
                new Curso("201", TiposJornada.Tarde),
                new Curso("301", TiposJornada.Noche),
                new Curso("101", TiposJornada.Mañana),
                new Curso("401", TiposJornada.Noche)
            };
            foreach (var c in escuela.Cursos)
            {
                Random rnd = new Random();
                int cantRandom = rnd.Next(10, 15);
                c.Alumnos = CargarAlumnosAlAzar(cantRandom);
            }
        }
    }
}