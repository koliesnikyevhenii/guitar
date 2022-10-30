using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarMarket1.Models
{
    internal class Guitar
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int AmountStrings { get; set; }
        public string Color { get; set; }
        public bool Neckline { get; set; }//what is it
        public string ManufacturerСountry { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            
            return $"Модель гитары { this.Name}, производитель { this.Brand}.\n" +
                   $" Имеет {this.AmountStrings} струн. Цвет {this.Color}.\n Страна изготовления {this.ManufacturerСountry}. Цена {this.Price}.\n\n";
        }



    }
}
