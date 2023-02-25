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

            escuela.Cursos = new List<Curso>();
            escuela.Cursos.Add(new Curso("101", TiposJornada.Mañana));
            escuela.Cursos.Add(new Curso("201", TiposJornada.Tarde));
            escuela.Cursos.Add(new Curso("301", TiposJornada.Noche));
        }

    }
}