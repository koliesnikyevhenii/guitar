using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarMarket1.Models
{
    public class GuitarGenerator
    {
        public string[] names = new string[5] { "F150", "KP30", "C40", "Telecaster", "2i2" };
        string[] brand = new string[5] { "Cort", "Yamaha", "Fender", "Ibanez", "Sigma" };
        public int[] amountString = new int[3] { 4, 7, 6 };
        public string[] color = new string[5] { "red", "blue", "black", "naturale", "sunbirst" };
        string[] manufacturerСountry = new string[5] { "China", "USA", "England", "Germany", "Ukraine" };
        float[] price = new float[5] { 100f, 150, 200, 70f, 55 };

        internal Guitar GenerateGuitar(int nameIndex, int brandIndex, int amountStringIndex,
            int colorIndex, int manufacturerСountryIndex, int priceIndex)
        {
            return new Guitar
            {
                Name = names[nameIndex],
                Brand = brand[brandIndex],
                AmountStrings = amountString[amountStringIndex],
                Color = color[colorIndex],
                ManufacturerСountry = manufacturerСountry[manufacturerСountryIndex],
                Price = price[priceIndex]
            };
        }
        public void GetNames()
        {
            foreach (var i in names)
            {
                Console.WriteLine($" {i}");
            }
        }
    }
}
