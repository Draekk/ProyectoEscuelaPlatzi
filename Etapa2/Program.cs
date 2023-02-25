
using ProyectoEscuelaPlatzi.Entidades;
using static System.Console;

EscuelaEngine eEngine = new EscuelaEngine();
eEngine.Inicializar();

Printer.EscribirTitulo("escuela platzi");

WriteLine(eEngine.escuela);
Printer.DibujarLinea(20);
Interaccion(eEngine.escuela);
ImprimirCursos(eEngine.escuela);
Printer.DibujarLinea(20);


void ImprimirCursos(Escuela escuela)
{
    foreach (var curso in escuela.Cursos)
    {
        WriteLine($"Nombre: {curso.Nombre}, Jornada: {curso.Jornada}, ID: {curso.UniqueId}");
    }
}

void Interaccion(Escuela escuela)
{

    WriteLine("¿Desea agregar mas cursos?");
    string respuesta = ReadLine().ToLower();
    while (respuesta != "no")
    {

        WriteLine("Introduzca el nombre del curso.");
        string nombre = ReadLine();

        WriteLine("Introduzca la jornada (Mañana, Tarde, Noche)");
        string jornada = ReadLine().ToLower();
        TiposJornada j = new TiposJornada();
        switch (jornada)
        {
            case "mañana":
                j = TiposJornada.Mañana;
                break;
            case "tarde":
                j = TiposJornada.Tarde;
                break;
            case "noche":
                j = TiposJornada.Noche;
                break;
            default:
                j = TiposJornada.Mañana;
                break;
        }

        escuela.Cursos.Add(new Curso(nombre, j));
        WriteLine("¿Desea continuar?");
        respuesta = ReadLine().ToLower();
    }
}