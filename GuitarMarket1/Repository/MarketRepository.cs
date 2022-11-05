using GuitarMarket1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GuitarMarket1.Repository
{
    class MarketRepository : IRepository
    {
        private static MarketRepository repository;

        public static MarketRepository GetInstance()
        {
            if (repository == null)
            {
                Console.WriteLine("I am created ");
                repository = new MarketRepository();
                return repository;
            }
            Console.WriteLine("I am just created ");
            return repository;
        }
        private MarketRepository()
        {
            
        }

        private List<Guitar> _guitars = new List<Guitar>();
        public void CreateGuitar(Guitar guitar)
        {
            foreach (var item in _guitars)
            {
                if (item.Equals(guitar))
                {
                    throw new Exception("Exception already exists");
                }
            }
            _guitars.Add(guitar);
        }

        public bool DeleteGuitar(string name)
        {
            foreach (var item in _guitars)
            {
                if (item.Name == name)
                {
                    _guitars.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public List<Guitar> GetAllGuitars()
        {
            return _guitars;
        }

        public void GetGuitarByAmountStrings(int amountStrings)
        {
            foreach (var item in _guitars)
            {
                if (item.AmountStrings == amountStrings)
                {
                    Console.WriteLine(item);
                }
            }
        }

        //
        //public Guitar GetGuitarByColor(string color)
        public void GetGuitarByColor(string color)
        {
            foreach (var item in _guitars)
            {
                if (item.Color == color)
                {
                    Console.WriteLine(item);
                }
                //}
                //throw new Exception("Exception not found");
            }
        }
            public void GetGuitarByName(string name)
            {
                foreach (var item in _guitars)
                {
                    if (item.Name == name)
                    {
                        Console.WriteLine(item);
                    }
                }
            }

            public void UpdateGuitar(Guitar guitar)
            {
                foreach (var item in _guitars)
                {
                    if (item.Name == guitar.Name)
                    {
                        item.Name = guitar.Name;
                        item.Neckline = guitar.Neckline;
                        item.ManufacturerСountry = guitar.ManufacturerСountry;
                        item.Brand = guitar.Brand;
                        item.Color = guitar.Color;
                        item.AmountStrings = guitar.AmountStrings;
                        item.Price = guitar.Price;//TODO дописать done
                    }
                }
                //throw new NotImplementedException();
            }
    }
    
} 


