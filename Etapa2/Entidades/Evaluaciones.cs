namespace ProyectoEscuelaPlatzi.Entidades
{
    public class Evaluaciones
    {
        public string UniqueId { get; private set; }
    
        public Evaluaciones()
        {
            UniqueId = Guid.NewGuid().ToString();
            
        }

        public float[] GenerarNotas()
        {
            float[] notas = new float[5];
            for (int i = 0; i < notas.Length; i++)
            {
                Random rnd = new Random();
                notas[i] = (float)rnd.NextDouble() * 5.00001f;
            }
            return notas;
        }
    }
}