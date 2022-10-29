using GuitarMarket1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarMarket1.Reports
{
    internal class ReportFileBuilder : IReportBuilder
    {
        public void GetTenCheepiestsGuitar(List<Guitar> guitars)
        {
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
            string path = "TenCheepiestsGuitar.txt";
            // полная перезапись файла 
            StreamWriter writer = new StreamWriter(path, false);
            foreach (var item in guitars)
            {
                writer.Write(item);
                count++;
                if (count == 10)
                {
                    writer.Close();
                    Console.WriteLine("Данные записаны в файл " + path);
                    break;
                }
            }

        }
    }
    
}
