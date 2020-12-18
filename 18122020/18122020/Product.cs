using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18122020
{
    public class Product
    {
        public enum Currency
        {
            AZN,
            RUBL,
            USD,
            EURO
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public Currency Currencyy { get; set; }



       
        


    }



}
