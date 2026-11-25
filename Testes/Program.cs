using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isSunny = true;
            double windSpeed = 5.4;
            int temperature = 23;
            int solarPanelOutput = 9;
            bool isCloudy = false;

            bool result = (isSunny == true) || (windSpeed < 10) || (solarPanelOutput < 15) || (temperature > 23 && !isCloudy);

            Console.WriteLine("Checking conditions for solar energy production...");
            Console.WriteLine($"1. Is it sunny? {isSunny}");
            Console.WriteLine($"2. Is wind speed safe? {windSpeed < 10}");
            Console.WriteLine($"3. Can panels produce more? {solarPanelOutput < 15}");
            Console.WriteLine($"4. Is temperature good OR no clouds? {temperature > 20 || !isCloudy}");
            Console.WriteLine($"\n Final Result - Good day for solar energy production: {result}");
              

        }
    }
}
