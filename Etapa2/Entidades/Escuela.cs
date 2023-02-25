namespace ProyectoEscuelaPlatzi.Entidades
{
    public class Escuela
    {
        public string UniqueId = Guid.NewGuid().ToString();
        private string nombre;
        public string Nombre{
            get{return nombre;}
            set{nombre = value.ToUpper();}
        }

        public int AñoDeCreacion { get; set; }

        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela tiposEscuela { get; set; }
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);
        public List<Curso> Cursos { get;set;}

        public Escuela(string nombre, int año, TiposEscuela tipo, string Pais = "", string Ciudad = "")
        {
            Nombre = nombre;
            AñoDeCreacion = año;
            tiposEscuela = tipo;
            this.Pais = Pais;
            this.Ciudad = Ciudad;
        }
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {tiposEscuela}{System.Environment.NewLine}Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}
