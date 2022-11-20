using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Bridge_Pattern_BuildingCompany_3
{
    public interface IBuildingCompany
    {
        void buildBasement();
        void buildRoof();
        void buildWall();
    }
}
