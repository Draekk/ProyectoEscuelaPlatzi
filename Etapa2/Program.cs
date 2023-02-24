
using ProyectoEscuelaPlatzi.Entidades;
using static System.Console;

var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria);
escuela.Pais = "Chile";
escuela.Ciudad = "Curacaví";
escuela.tiposEscuela = TiposEscuela.Primaria;

escuela.Cursos = new List<Curso>();
escuela.Cursos.Add(new Curso("101", TiposJornada.Mañana));
escuela.Cursos.Add(new Curso("201", TiposJornada.Tarde));
escuela.Cursos.Add(new Curso("301", TiposJornada.Noche));

Console.WriteLine(escuela);
System.Console.WriteLine("======================================");
Interaccion(escuela.Cursos);
ImprimirCursos(escuela.Cursos);

void ImprimirCursos(List<Curso> cursos)
{
    foreach (var curso in cursos)
    {
        System.Console.WriteLine($"Nombre: {curso.Nombre}, Jornada: {curso.Jornada}, ID: {curso.UniqueId}");
    }
}

void Interaccion(List<Curso> cursos){

    WriteLine("¿Desea agregar mas cursos?");
    string respuesta = ReadLine().ToLower();
    while(respuesta != "no"){

        WriteLine("Introduzca el nombre del curso.");
        string nombre = ReadLine();
        
        WriteLine("Introduzca la jornada (Mañana, Tarde, Noche)");
        string jornada = ReadLine().ToLower();
        TiposJornada j = new TiposJornada();
        switch(jornada){
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

        cursos.Add(new Curso(nombre, j));
        WriteLine("¿Desea continuar?");
        respuesta = ReadLine().ToLower();
    }
}