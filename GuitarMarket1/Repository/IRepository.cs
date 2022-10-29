using GuitarMarket1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarMarket1.Repository
{
    interface IRepository
    {
        void CreateGuitar(Guitar guitar);
               //TODO: определить ексепшн
        bool DeleteGuitar(string name);
        void GetGuitarByColor(string color);
        void GetGuitarByAmountStrings(int amountStrings);
        void GetGuitarByName(string name); //TODO: нужно добавить фильтр для поиска(новый тип данных на вход в этот метод) done
        List<Guitar> GetAllGuitars();
        void UpdateGuitar(Guitar guitar);
    }
}
