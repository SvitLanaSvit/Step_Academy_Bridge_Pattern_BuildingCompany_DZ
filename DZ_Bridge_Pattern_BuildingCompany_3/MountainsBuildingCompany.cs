using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Bridge_Pattern_BuildingCompany_3
{
    public class MountainsBuildingCompany : WallCreator
    {
        public MountainsBuildingCompany(IBuildingCompany company) : base(company)
        {
        }
    }
}
