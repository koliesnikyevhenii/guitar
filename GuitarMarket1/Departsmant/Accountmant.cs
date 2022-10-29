using GuitarMarket1.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarMarket1.Departsmant
{
    internal class Accountmant
    {
        private IReportBuilder _reportBuilder;
        public Accountmant(IReportBuilder builder)
        {
            _reportBuilder = builder;
        }

        void GetStatistic()
        {
            
        }
    }
}
