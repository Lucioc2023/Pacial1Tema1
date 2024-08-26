namespace ValidarFecha.Entidades
{
    public static class ValidarFecha
    {
        public static bool Validar(int dia, int mes, int anio)
        {
            if (mes < 1 || mes > 12) return false;
            if (anio < 1 || anio > 99999999) return false;
            if (dia < 1 || dia > 31) return false;

            switch (mes)
            {
                case 2:
                    if (EsBiciesto(anio) && (dia >= 1 && dia <= 29))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    if (dia >= 1 && dia <= 30)
                    {
                        return true;
                    }
                    return false;
                default:
                    if (dia >= 1 && dia <= 31)
                    {
                        return true;
                    }
                    return false;
            }

        }
        private static bool EsBiciesto(int anio)
        {
            return anio%4 == 0 && anio%100 != 0 || anio %400==0;
        }
    }
}
