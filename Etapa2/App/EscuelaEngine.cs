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

            escuela.Cursos = new List<Curso>(){
                new Curso("201", TiposJornada.Tarde),
                new Curso("301", TiposJornada.Noche),
                new Curso("101", TiposJornada.Mañana),
                new Curso("401", TiposJornada.Noche)
            };

        }

    }
}