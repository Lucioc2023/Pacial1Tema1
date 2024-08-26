using System.Text;

namespace PiramedeCuadr.Entidades
{
    public class PiramideCuadrada
    {

        //lado de la base y la altura
        public int LadoBase { get; }
        public int Altura { get; }
        private double Apotema;

        public PiramideCuadrada(int ladoBase, int altura)
        {
            
            if (ladoBase <=0 || altura <=0) 
            {
                throw new ArgumentException("No valido");                
            }
            LadoBase = ladoBase;
            Altura = altura;
            CalcularApotema();
        }

        private void CalcularApotema()
        {
            Apotema=Math.Sqrt(Math.Pow(LadoBase/2,2)+Math.Pow(Altura,2));
        }
        public double GetAreaTotal()
        { 
             return GetAreaBase()+GetAreaLateral();          

        }
        private double GetAreaLateral() => 2 * LadoBase * Apotema;
        private double GetAreaBase()=> Math.Pow(LadoBase, 2);
        public double GetVolumen()=> (Math.Pow(LadoBase, 2)*Altura)/3;

        public string GetInfo()
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine($"Piramide Cuadrada");
            sb.AppendLine($"\t Base: {LadoBase}");
            sb.AppendLine($"\t Altura: {Altura}");
            sb.AppendLine($"\t Apotema: {Apotema}");
            sb.AppendLine($"\t Area total: {GetAreaTotal()}");
            sb.AppendLine($"\t Volumen: {GetVolumen()}");
            return sb.ToString();
        }
        
    }
}
