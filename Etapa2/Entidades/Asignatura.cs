namespace ProyectoEscuelaPlatzi.Entidades
{
    public class Asignatura
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public float[] Notas { get; set; }
        public Asignatura(string nombre, float[] notas)
        {
            UniqueId = Guid.NewGuid().ToString();
            Nombre = nombre;
            Notas = notas;
        }
    }
}