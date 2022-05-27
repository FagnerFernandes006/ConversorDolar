using System.Globalization;

namespace Dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar Hoje?: ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você irá comprar? ");
            int qtde = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valor = ConversorDeMoeada.Valor(dolar, qtde);
            Console.WriteLine("Valor a ser pago: R$" + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}