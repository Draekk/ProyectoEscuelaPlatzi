
using ProyectoEscuelaPlatzi.Entidades;

var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria);
escuela.Pais = "Chile";
escuela.Ciudad = "Curacaví";
escuela.tiposEscuela = TiposEscuela.Primaria;
Console.WriteLine(escuela);
