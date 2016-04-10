using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houses
{
    public class Painter
    {
        string name;
        int daysPerHouse;

        public Painter(string name, int daysPerHouse)
        {
            this.name = name;
            this.daysPerHouse = daysPerHouse;
        }

        public double PaintFor(double totalDays)
        {
            var totalHouses = totalDays / daysPerHouse;
            Console.WriteLine("{0} painting {1:0.00} houses for {2:0.00} days", name, totalHouses, totalDays);
            return totalHouses;
        }

        public int EstimateDays(int houseCount)
        {
            return houseCount * daysPerHouse;
        }
    }
}
