namespace _42.Entidades
{
    public class NumeroArmstrong
    {
        public int Valor { get; set; }

        public NumeroArmstrong(int valor)
        {
            Valor = valor;
        }

        public bool EsArmstrong()
        {
            int suma = 0;
            int numero = Valor;
            int cantidadDigitos = Valor.ToString().Length;

            while (numero > 0)
            {
                int digito = numero % 10;
                suma += (int)Math.Pow(digito, cantidadDigitos);
                numero /= 10;
            }

            return suma == Valor;
        }

        public override string ToString()
        {
            return Valor.ToString();
        }

        public override bool Equals(object? obj)
        {
            if (obj is NumeroArmstrong otro)
            {
                return this.Valor == otro.Valor;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Valor.GetHashCode();
        }

        public static bool operator ==(NumeroArmstrong a, NumeroArmstrong b)
        {            
            return a.Valor== b.Valor;
        }

        public static bool operator !=(NumeroArmstrong a, NumeroArmstrong b)
        {
            return !(a.Valor == b.Valor);
        }
    }
}
