using System;
using System.Collections.Generic;
using System.Text;

namespace ScrollingMessage
{
    public class Ticker : IComponent
    {
        public string Price { get; set; }
        public string Name { get; set; }

        public Ticker(string name, string price)
        {
            this.Price = price;
            this.Name = name;
        }

        public void DisplayPrice()
        {
            Console.WriteLine(Name + " : " + Price);
        }

        public string GetPrice()
        {
            return (Name + " : " + Price);
        }
    }
}
