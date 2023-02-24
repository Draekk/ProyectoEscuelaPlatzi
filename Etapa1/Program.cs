
using ProyectoEscuelaPlatzi.Entidades;

var escuela = new Escuela("Platzi Academy", 2012);
escuela.Pais = "Chile";
escuela.Ciudad = "Curacaví";
escuela.tiposEscuela = TiposEscuela.Primaria;
Console.WriteLine(escuela);
