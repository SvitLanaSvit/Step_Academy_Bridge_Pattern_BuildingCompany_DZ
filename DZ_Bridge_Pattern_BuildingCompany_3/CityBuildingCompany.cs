using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Bridge_Pattern_BuildingCompany_3
{
    public class CityBuildingCompany : WallCreator
    {
        public CityBuildingCompany(IBuildingCompany company) : base(company)
        {
        }
    }
}
