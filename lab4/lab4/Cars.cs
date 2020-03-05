using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lab4
{
    public class Car : IComparable<Car>, IComparer<Car>
    {
        public int year;
        public string brand;
        private string[] options_of_brands = new string[10]
        {
            "Skoda", "Volkswagen", "Mercedes-Benz", "Audi", "Porsche",
            "BMW", "Range Rover", "Chevrolet", "Citroen", "MINI"
        };

        public Car()
        {
            Random random = new Random();
            this.year = (int)random.Next(1990, 2020);
            Thread.Sleep(10);
            this.brand = options_of_brands[random.Next(0, 10)];
            Thread.Sleep(10);
        }

        public int Compare(Car st1, Car st2)
        {
            return st2.CompareTo(st1);
        }

        public int CompareTo(Car car)
        {
            if (car == null)
            {
                return 1;
            }
            else
            {
                if (this.year > car.year)
                {
                    return 1;
                }
                else if (this.year < car.year)
                {
                    return -1;
                }
                else
                {
                    return this.brand.CompareTo(car.brand);
                }

            }
        }
    }
}
