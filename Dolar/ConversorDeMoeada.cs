namespace Dolar
{
    public class ConversorDeMoeada
    {
        public static double IOF = 0.06;

        public static double Valor(double dolar, int qtde)
        {
            return dolar * qtde + (dolar * IOF * qtde);
        }
    }
}
