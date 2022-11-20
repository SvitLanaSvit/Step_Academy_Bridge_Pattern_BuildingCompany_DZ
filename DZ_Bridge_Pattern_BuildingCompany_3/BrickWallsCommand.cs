using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Bridge_Pattern_BuildingCompany_3
{
    public class BrickWallsCommand : IBuildingCompany
    {
        public void buildBasement()
        {
            Console.WriteLine("The Basement is built depending on the soil.");
        }

        public void buildRoof()
        {
            Console.WriteLine("The roof is built depending on the weather requirements.");
        }

        public void buildWall()
        {
            Console.WriteLine("The Walls are built from bricks.");
        }
    }
}
