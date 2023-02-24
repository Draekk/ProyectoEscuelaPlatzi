
using ProyectoEscuelaPlatzi.Entidades;

var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria);
escuela.Pais = "Chile";
escuela.Ciudad = "Curacaví";
escuela.tiposEscuela = TiposEscuela.Primaria;

var arregloCursos = new Curso[3];
arregloCursos[0] = new Curso()
{
    Nombre = "101"
};
arregloCursos[1] = new Curso()
{
    Nombre = "201"
};
arregloCursos[2] = new Curso()
{
    Nombre = "301"
};
Console.WriteLine(escuela);
System.Console.WriteLine("======================================");

ImprimirCursos(arregloCursos);

void ImprimirCursos(Curso[] arregloCursos)
{
    foreach (var curso in arregloCursos)
    {
        System.Console.WriteLine($"Nombre: {curso.Nombre}, ID: {curso.UniqueId}");
    }
}