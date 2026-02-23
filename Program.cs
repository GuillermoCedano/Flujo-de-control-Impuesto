using System.ComponentModel.Design;
using System.Diagnostics.SymbolStore;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("CALCULADORA DE IMPUESTOS:");
        Console.WriteLine("Cual es tu sueldo mensual?");
        int S = int.Parse(Console.ReadLine());

        // Formula:

        int SA = S * 12;


        if (SA <= 416220)
        {
            Console.WriteLine("Sueldo: RD$" + S);
            Console.WriteLine("ISR: N/A");
        }
        else if (SA > 416220 && SA <= 624329)
        {
            Double I2 = (SA - 416220) * 0.15;
            double ST2 = (SA - I2);
            Console.WriteLine("Sueldo: RD$" + ST2);
            Console.WriteLine("ISR: RD$" + I2);
        }
        else if (SA > 624329 && SA<= 867123)
        {

            Double I3 = (SA - 624329) * 0.20 + 31216;
            double ST3 = (SA - I3);
            Console.WriteLine("Sueldo: RD$" + ST3);
            Console.WriteLine("ISR: RD$" + I3);
        }
        else
        {
            Double I4 = (SA - 867123) * 0.25 + 79776;
            double ST4 = (SA - I4);
            Console.WriteLine("Sueldo: RD$" + ST4);
            Console.WriteLine("ISR: RD$" + I4);
        }
    }
}