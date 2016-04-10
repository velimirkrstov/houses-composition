using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houses
{
    public class LandOwner
    {
        private int totalHouses;
        private IEnumerable<Painter> painters;

        public LandOwner(int totalHouses, IEnumerable<Painter> painters)
        {
            this.totalHouses = totalHouses;
            this.painters = new List<Painter>(painters);
        }

        public void MantainHouse()
        {
            double totalVelocity = painters
                                        .Select(p => p.EstimateDays(1))
                                        .Select(p => 1 / (double)p).Sum();


            double totalDays = this.totalHouses / totalVelocity;

            double totalHouses = painters.Select(p => p.PaintFor(totalDays)).Sum();

            Console.WriteLine("\nPainted {0:0} houses.", totalHouses);

        }
    }
}
