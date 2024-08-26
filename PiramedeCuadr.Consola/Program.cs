using PiramedeCuadr.Entidades;

namespace PiramedeCuadr.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            PiramideCuadrada piramide= new PiramideCuadrada(6, 12);
            Console.WriteLine(piramide.GetInfo());

        }
    }
}
