using System.Numerics;

namespace Armstrong.Entidades
{
    public class Armstrong
    {
        private int Valor { get; set; }
        public Armstrong(int valor)
        {
            Valor = valor;
        }
        public bool EsValido()
        {
            int suma = 0;
            int temp =Valor;
            int n = Valor.ToString().Length;
            while (temp > 0)
            {
                int digito = temp % 10;
                suma += (int)Math.Pow(digito, n);
                temp/=10;
            }
            return suma ==Valor;
        }
        public override string ToString()
        {//Sobrescribir los métodos heredados de Object.
            return $"{Valor}";
        }
        //*******************************************
        public static bool operator==(Armstrong a, Armstrong b)
        {
            return a.Valor == b.Valor ;
        }
        public static bool operator !=(Armstrong a, Armstrong b)
        {
            return !(a==b);
        }
        //*******************************************
        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Armstrong armstrong)) return false;
            return this == armstrong;          
        }
        public override int GetHashCode()
        {
            return Valor.GetHashCode();           
        }
    }
}
