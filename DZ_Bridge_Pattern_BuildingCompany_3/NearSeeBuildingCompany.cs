using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Bridge_Pattern_BuildingCompany_3
{
    public class NearSeeBuildingCompany : WallCreator
    {
        public NearSeeBuildingCompany(IBuildingCompany company) : base(company)
        {
        }
    }
}
