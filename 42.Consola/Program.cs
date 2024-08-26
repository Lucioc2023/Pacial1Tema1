using _42.Datos;
using _42.Entidades;

namespace _42.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioNumerosArmstrong repositorio = new RepositorioNumerosArmstrong();
            int opcion;

            do
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Agregar número Armstrong");
                Console.WriteLine("2. Quitar número Armstrong");
                Console.WriteLine("3. Listar números Armstrong");
                Console.WriteLine("4. Buscar número Armstrong");
                Console.WriteLine("5. Sumar números Armstrong");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese un número: ");
                        int valorAgregar = Convert.ToInt32(Console.ReadLine());
                        NumeroArmstrong numeroAgregar = new NumeroArmstrong(valorAgregar);
                        if (numeroAgregar.EsArmstrong())
                        {
                            var resultadoAgregar = repositorio.Agregar(numeroAgregar);
                            Console.WriteLine(resultadoAgregar.Item2);
                        }
                        else
                        {
                            Console.WriteLine("El número no es un número Armstrong.");
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese un número a quitar: ");
                        int valorQuitar = Convert.ToInt32(Console.ReadLine());
                        var resultadoQuitar = repositorio.Quitar(new NumeroArmstrong(valorQuitar));
                        Console.WriteLine(resultadoQuitar.Item2);
                        break;

                    case 3:
                        Console.WriteLine(repositorio.ListarNumeros());
                        break;

                    case 4:
                        Console.Write("Ingrese un número a buscar: ");
                        int valorBuscar = Convert.ToInt32(Console.ReadLine());
                        var resultadoBuscar = repositorio.BuscarNumero(valorBuscar);
                        if (resultadoBuscar.Item1)
                        {
                            Console.WriteLine($"El número se encuentra en la posición: {resultadoBuscar.Item2}");
                        }
                        else
                        {
                            Console.WriteLine("El número no se encuentra en el repositorio.");
                        }
                        break;

                    case 5:
                        int suma = repositorio;
                        Console.WriteLine($"La suma de los números Armstrong es: {suma}");
                        break;

                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                Console.WriteLine();
            } while (opcion != 0);
        }
    }
}
