using GuitarMarket1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarMarket1.Reports 
{
    class ReportBuilder : IReportBuilder
    {
        public void GetTenCheepiestsGuitar(List <Guitar> guitars) //отчет в консоль
        {
            //var cheepiestGuiter = guitars.OrderByDescending(x=>x.Price).Take(10);
            
            Guitar a;
            for (int i = 1; i < guitars.Count; i++)
            {
                for (int j = 0; j < guitars.Count - i; j++)
                {
                    if (guitars[j].Price > guitars[j + 1].Price)
                    {
                        a = guitars[j];
                        guitars[j] = guitars[j + 1];
                        guitars[j + 1] = a;
                    }
                }
            }
            int count = 0; 
            foreach (var item in guitars)
            {
                
                Console.WriteLine(item);
                count++;
                if (count == 10)
                {
                    break;
                }
            }

        }


    }
}