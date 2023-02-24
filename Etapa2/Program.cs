
using ProyectoEscuelaPlatzi.Entidades;

var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria);
escuela.Pais = "Chile";
escuela.Ciudad = "Curacaví";
escuela.tiposEscuela = TiposEscuela.Primaria;

var curso1 = new Curso(){
    Nombre = "101"
};
var curso2 = new Curso(){
    Nombre = "201"
};
var curso3 = new Curso(){
    Nombre = "301"
};
Console.WriteLine(escuela);
System.Console.WriteLine("================================");
System.Console.WriteLine(curso1.Nombre + ", " + curso1.UniqueId);
System.Console.WriteLine(curso2.Nombre + ", " + curso2.UniqueId);
System.Console.WriteLine(curso3);
