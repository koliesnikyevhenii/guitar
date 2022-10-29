using GuitarMarket1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarMarket1.Models;
using GuitarMarket1.Reports;
using GuitarMarket1.Departsmant;

namespace GuitarMarket1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            IRepository GuitarsStore = new MarketRepository();
           //Guitar test = GuitarsStore.GetGuitarByName("a15");

            GuitarGenerator guitarGenerator = new GuitarGenerator();

            int nameIndex;
            int brandIndex;
            int amountStringIndex;
            int colorIndex;
            int manufacturerСountryIndex;
            int priceIndex;


            for (int i = 0; i < 100; i++)
            {
                nameIndex = rnd.Next(4);
                brandIndex = rnd.Next(4);
                amountStringIndex = rnd.Next(2);
                colorIndex = rnd.Next(4);
                manufacturerСountryIndex = rnd.Next(4);
                priceIndex = rnd.Next(4);
                 
                
                var guitar = guitarGenerator.GenerateGuitar(nameIndex, brandIndex, amountStringIndex, colorIndex, manufacturerСountryIndex, priceIndex);
                GuitarsStore.CreateGuitar(guitar);
            }
            var allGuitars = GuitarsStore.GetAllGuitars();
            

            int index = 0;
            switch (index)
            {
                case 0:
                    {
                        Console.Clear();
                        Console.WriteLine("        МЕНЮ\n 1.Показать все гитары\n" +
                        " 2.Показать 10 самых дешевых\n 3.Поиск по значению\n "); 
                        index=Convert.ToInt32(Console.ReadLine());
                        if (index == 1)
                            goto case 1;
                        if (index == 2)
                            goto case 2;
                        if (index == 3)
                            goto case 3;
                    }
                    break;
                case 1:
                    {
                        Console.Clear();
                        int count = 1;
                        foreach (var guitar in allGuitars)
                        {
                            Console.WriteLine($" Гитара({count}) {guitar}");
                            count++;
                        }
                        Console.ReadKey();
                        goto case 0; 
                    }
                    // переход к case 5
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("     Показать 10 самых дешевых\n 1. в консоль\n 2. в файл");
                        int index1 = Convert.ToInt32(Console.ReadLine());
                        if (index1 == 0)
                            goto case 0;
                        if (index1 == 1)
                            goto case 4;
                        if (index1 == 2)
                            goto case 5;
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("     Поиск\n 1. по имени\n 2. по цвету\n 3. по количеству струн");
                        int index1 = Convert.ToInt32(Console.ReadLine());
                        if (index1 == 0)
                            goto case 0;
                        if (index1 == 1)
                            goto case 6;
                        if (index1 == 2)
                            goto case 7;
                        if (index1 == 3)
                            goto case 8;
                    }
                    break;
                case 4:
                    {
                        Console.Clear();
                        IReportBuilder reportBuilder = new ReportBuilder();
                        reportBuilder.GetTenCheepiestsGuitar(allGuitars);
                        Console.ReadKey();
                        goto case 0;
                    }
                case 5:
                    {
                        Console.Clear();
                        IReportBuilder reportFileBuilder = new ReportFileBuilder();
                        reportFileBuilder.GetTenCheepiestsGuitar(allGuitars);

                        Console.ReadKey();
                        goto case 0;
                    }
                case 6:
                    {
                        Console.Clear();
                        Console.WriteLine("       Список имён гитар");
                        foreach (var names in guitarGenerator.names)
                        {
                            Console.WriteLine($" {names}");
                        }
                        Console.WriteLine("  Введите название");
                        string newNames = Console.ReadLine();
                        GuitarsStore.GetGuitarByName(newNames);
                        Console.ReadKey();
                        goto case 3;
                    }
                case 7:
                    {
                        Console.Clear();
                        Console.WriteLine("       Список цветов гитар");
                        foreach (var colors in guitarGenerator.color)
                        {
                            Console.WriteLine($" {colors}");
                        }
                        Console.WriteLine("Введите название");
                        string newColor = Console.ReadLine();
                        GuitarsStore.GetGuitarByColor(newColor);
                        Console.ReadKey();
                        goto case 3;
                    }
                case 8:
                    {
                        Console.Clear();
                        Console.WriteLine("       Количество струн");
                        foreach (var str in guitarGenerator.amountString)
                        {
                            Console.WriteLine($" {str}");
                        }
                        Console.WriteLine("Введите название");
                        int newStr = Convert.ToInt16(Console.ReadLine());
                        GuitarsStore.GetGuitarByAmountStrings(newStr);
                        Console.ReadKey();
                        goto case 3;
                    }

                default:
                    Console.WriteLine("default");
                    break;
            }
        }
       
    }
}
