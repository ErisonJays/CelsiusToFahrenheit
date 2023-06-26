using CelsiusToFahrenheit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CelsiusToFahrenheit.Pages
{
    public class TemperatureModel : PageModel
    {
        public double TemperatureCelsius;
        public double TemperatureFahrenheit;
        public void OnGet()
        {
        }

        public void OnPost()
        {
            TemperatureCelsius = Convert.ToDouble(Request.Form["TemperatureCelsius"]);
            TemperatureFahrenheit = Temperature.CelsiusToFahrenheit(TemperatureCelsius);
        }
    }
}
