using static System.Console;
namespace ProyectoEscuelaPlatzi.Entidades
{
    public static class Printer
    {
        public static void DibujarLinea(int tamaño){
            WriteLine("".PadLeft(tamaño, '*'));
        }

        public static void EscribirTitulo(string titulo){
            DibujarLinea(titulo.Length);
            WriteLine(titulo.ToUpper());
            DibujarLinea(titulo.Length);
        }
    }
}