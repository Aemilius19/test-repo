using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Book
    {
        public  string name;
        double _price;
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("price siir olmali deyil");
                }
            }
        }
        public Book(string name, double price)
        {
            this.name = name;
            Price = price;
        }
    }
}
