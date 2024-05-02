namespace KonversiSuhuLibraries
{
    public static class KonversiSuhu
    {
        public static double CelsiuskeFahrenheit(double inCelsius)
        {
            return (inCelsius * 9 / 5) + 32;
        }

        public static double FahrenheitkeCelsius(double inFahrenheit)
        {
            return (inFahrenheit - 32) * 5 / 9;
        }
    }
}
