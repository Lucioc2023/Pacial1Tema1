using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas.Entidades
{
    public class Fahrenheit
    {
        //grados de tipo float
        private float grados;
        public float GetGrados() => grados;//método para informar Grados.
        public Fahrenheit(float Grados = 5)
        {//se proporciona el valor del atributo grados, que por defecto inicializa en 5.
            this.grados = Grados;
        }
        public static implicit operator float(Fahrenheit fahrenheit)
        {//Hacer la sobrecarga implícita entre float y las temperaturas.
            return fahrenheit.grados;
        }
        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return f1.grados == f2.grados;
        }
        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }
        //***************************************************
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.GetGrados() * (9 / 5) + 32);            
        }
        //***************************************************
        public static bool operator ==(Fahrenheit f, Celsius c )
        {
            return f == (Fahrenheit)c;
        }
        public static bool operator !=(Fahrenheit f,Celsius c )
        {
            return !(f == (Fahrenheit)c);
        }
        //***************************************************
        public static Fahrenheit operator +(Fahrenheit f1, Fahrenheit f2)
        {
            return new Fahrenheit(f1.GetGrados() + f2.GetGrados());
        }
        public static Fahrenheit operator -(Fahrenheit f1, Fahrenheit f2)
        {
            return new Fahrenheit(f1.GetGrados() - f2.GetGrados());
        }
        //***************************************************
        public static Fahrenheit operator +(Fahrenheit f, Celsius c1)
        {
            return f + (Fahrenheit)c1;
        }
        public static Fahrenheit operator -(Fahrenheit f, Celsius c1)
        {
            return f - (Fahrenheit)c1;
        }
        //***************************************************
        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Fahrenheit fahrenheit)) return false;
            return this.grados == fahrenheit.grados;
        }

        public override int GetHashCode()
        {
            return this.grados.GetHashCode();
        }
    }
}
