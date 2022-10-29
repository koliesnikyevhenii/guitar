using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarMarket1.Keyboard
{
    internal class KeyboardGenerator
    {
        string[] brandKeyb = new string[6] { "Korg", "Yamaha", "Casio", "Kawai", "Roland", "Nord" };
        string[] namesKeyb = new string[5] { "Pa900", "Kronos", "Tyros", "Fantom 6", "Stage 3" };
        int[] amountKeyb = new int[3] { 61, 76, 88 };
        string[] colorKeyb = new string[5] { "red", "blue", "black", "natural", "sunburst" };
        string[] keyboardQuality = new string[3] { "weighted", "unweighted", "semi-weighted" };
        string[] manufacturerСountryKeyboard = new string[5] { "China", "USA", "England", "Germany", "Ukraine" };
        int [] priceKeyb = new int[10] { 1600, 1500, 200, 700, 550, 1000, 2356, 750, 2000, 3000 };

        internal Keyboard GenerateKeyboard(int nameIndex, int brandIndex, int amountKeysIndex,
            int colorIndex, int keyboardQualityIndex, int manufacturerСountryIndex, int priceIndex)
        {
            return new Keyboard
            {
                NameKeyboard = namesKeyb[nameIndex],
                BrandKeyboard = brandKeyb[brandIndex],
                AmountKeysKeyboard = amountKeyb[amountKeysIndex],
                ColorKeyboard = colorKeyb[colorIndex],
                KeyboardQuality = keyboardQuality[keyboardQualityIndex],
                ManufacturerСountryKeyboard = manufacturerСountryKeyboard[manufacturerСountryIndex],
                PriceKeyboard = priceKeyb[priceIndex]
            };
            
        }
    }
}
