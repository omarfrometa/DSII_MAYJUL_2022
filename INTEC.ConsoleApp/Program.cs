using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTEC.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LOTERIA DE INTEC");
            Console.WriteLine($"Del dia {DateTime.Now.ToString("F")}");
            Console.WriteLine("");
            Console.ReadLine();

            Random rnd = new Random();
            
            int p1 = rnd.Next(100);
            Console.WriteLine($"Primer Numero:=========>  {p1}");
            System.Threading.Thread.Sleep(2500);

            int p2 = rnd.Next(100);
            Console.WriteLine($"Segundo Numero:========>  {p2}");
            System.Threading.Thread.Sleep(2500);

            int p3 = rnd.Next(100);
            Console.WriteLine($"Tercer Numero:=========>  {p3}");
            System.Threading.Thread.Sleep(2500);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("LOS NUMEROS GANADORES FUERON");
            Console.WriteLine($"1ra. ({p1}) - 2da. ({p2}) - 3ra. ({p3})");
            Console.ReadLine();
        }
    }
}
