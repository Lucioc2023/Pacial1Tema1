using System.Numerics;

namespace Temperaturas.Entidades
{
    public class Celsius
    {//grados de tipo float
        private float grados;
        public float GetGrados()=> grados;//método para informar Grados.
        public Celsius(float Grados=5)
        {//se proporciona el valor del atributo grados, que por defecto inicializa en 5.
            this.grados = Grados;
        }
        public static implicit operator float(Celsius celsius)
        {//Hacer la sobrecarga implícita entre float y las temperaturas.
            return celsius.grados;
        }
        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return c1.grados == c2.grados;
        }
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1==c2);
        }
        //***************************************************
        public static explicit operator Celsius(Fahrenheit fa)
        {
            return new Celsius((fa.GetGrados() - 32) * 5 / 9);
        }
        //***************************************************
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return c == (Celsius)f;
        }
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == (Celsius)f);
        }
        //***************************************************
        public static Celsius operator +(Celsius c1, Celsius c2)
        {
            return new Celsius(c1.GetGrados()+c2.GetGrados()); 
        }
        public static Celsius operator -(Celsius c1, Celsius c2)
        {
            return new Celsius(c1.GetGrados() - c2.GetGrados());
        }
        //***************************************************
        public static Celsius operator +(Celsius c1, Fahrenheit f)
        {
            return c1+(Celsius)f;
        }
        public static Celsius operator -(Celsius c1, Fahrenheit f)
        {
            return c1 - (Celsius)f;
        }
        //***************************************************
        public override bool Equals(object? obj)
        {
            if (obj is  null || !(obj is Celsius celsius))return false;
            return this.grados == celsius.grados;
        }

        public override int GetHashCode()
        {
            return this.grados.GetHashCode();
        }
    }
}
