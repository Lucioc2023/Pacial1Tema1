using _42.Entidades;

namespace _42.Datos
{
    public class RepositorioNumerosArmstrong
    {
        private int cantidad;
        private NumeroArmstrong[] numeros;

        public RepositorioNumerosArmstrong(int cantidad)
        {
            this.cantidad = cantidad;
            numeros = new NumeroArmstrong[cantidad];
        }

        public RepositorioNumerosArmstrong() : this(5) { }

        public int Cantidad => cantidad;

        private bool EstaCompleto()
        {
            return Array.FindAll(numeros, n => n != null).Length >= cantidad;
        }

        private bool EstaVacio()
        {
            return Array.FindAll(numeros, n => n != null).Length == 0;
        }

        private bool Existe(NumeroArmstrong numero)
        {
            return Array.Exists(numeros, n => n != null && n.Equals(numero));
        }

        public (bool, string) Agregar(NumeroArmstrong numero)
        {
            if (EstaCompleto())
                return (false, "El repositorio está completo.");

            if (Existe(numero))
                return (false, "El número ya existe en el repositorio.");

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == null)
                {
                    numeros[i] = numero;
                    return (true, "Número agregado correctamente.");
                }
            }

            return (false, "No se pudo agregar el número.");
        }

        public (bool, string) Quitar(NumeroArmstrong numero)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] != null && numeros[i].Equals(numero))
                {
                    numeros[i] = null;
                    return (true, "Número quitado correctamente.");
                }
            }
            return (false, "El número no se encuentra en el repositorio.");
        }

        public NumeroArmstrong ObtenerElemento(int indice)
        {
            if (indice < 0 || indice >= numeros.Length)
                throw new IndexOutOfRangeException("Índice fuera de rango.");

            return numeros[indice];
        }

        public string ListarNumeros()
        {
            if (EstaVacio())
                return "No hay elementos almacenados todavía.";

            string resultado = "";
            foreach (var numero in numeros)
            {
                resultado += numero != null ? numero.ToString() : "Elemento Nulo";
                resultado += "\n";
            }
            return resultado.Trim();
        }

        public (bool, int) BuscarNumero(int valor)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] != null && numeros[i].Valor == valor)
                {
                    return (true, i);
                }
            }
            return (false, -1);
        }

        public static implicit operator int(RepositorioNumerosArmstrong repo)
        {
            int suma = 0;
            foreach (var numero in repo.numeros)
            {
                if (numero != null)
                {
                    suma += numero.Valor;
                }
            }
            return suma;
        }
    }
}
