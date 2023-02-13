using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_130223
{
    internal class Money
    {
        public int Dollars { get; set; }
        public int Cents { get; set; }

        public Money(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
        }

        public void DisplaySum()
        {
            Console.WriteLine($"{Dollars}.{Cents:00}");
        }

        public void Reduce(int dollars, int cents)
        {
            Dollars -= dollars;
            Cents -= cents;
            if (Cents < 0)
            {
                Dollars--;
                Cents += 100;
            }
        }
    }

    internal class Product : Money
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Product(string name, string description, int dollars, int cents) : base(dollars, cents)
        {
            Name = name;
            Description = description;
        }

        public void ReducePrice(int percent)
        {
            int reductionDollars = (Dollars * percent) / 100;
            int reductionCents = (Cents * percent) / 100;
            Reduce(reductionDollars, reductionCents);
        }
    }

}
