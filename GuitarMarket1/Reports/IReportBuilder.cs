using GuitarMarket1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarMarket1.Reports
{
    internal interface IReportBuilder
    {
        void GetTenCheepiestsGuitar(List<Guitar> guitars);
    }
}
