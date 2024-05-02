using KonversiSuhuLibraries;
using System;

namespace KalkulatorSuhu {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan suhu dalam celsius: ");
            double suhuC = double.Parse(Console.ReadLine());
            double suhuF = KonversiSuhu.CelsiuskeFahrenheit(suhuC);
            Console.WriteLine("Suhu dalam Fahrenheit: " + suhuF);
        }
    }
}