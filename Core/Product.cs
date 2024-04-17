using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Product
    {
        static int _no;
        public int No { get; set; }
        public string Name { get; set; }

        private double _price;
        public Type Type { get; set; }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentException("Price 0-dan asagi ola bilmez!");
                }
            }
        }
        public Product()
        {

        }
        public Product(int no,string name, double price)
        {
            _no++;
            No = no;
            Name = name;
            Price = price;
        }
    }
}
