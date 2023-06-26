namespace CelsiusToFahrenheit.Models
{
    public class Temperature
    {
        public static double CelsiusToFahrenheit(double Tc)
        {
            double Tf;
            Tf = Tc * 9 / 5 + 32;

            return Tf;
        }
    }
}
