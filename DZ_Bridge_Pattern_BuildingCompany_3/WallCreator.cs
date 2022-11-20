using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Bridge_Pattern_BuildingCompany_3
{
    public abstract class WallCreator
    {
        protected IBuildingCompany buildingCompany;

        public IBuildingCompany BuildingCompany { set { buildingCompany = value; } }
        public WallCreator(IBuildingCompany company) { buildingCompany = company; }
        public virtual void DoWork()
        {
            buildingCompany.buildBasement();
            buildingCompany.buildWall();
            buildingCompany.buildRoof();
        }
    }
}
