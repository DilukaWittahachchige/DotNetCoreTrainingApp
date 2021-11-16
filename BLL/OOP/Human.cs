using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.OOP
{
    //Multiple inheritance using interfaces
    public class Human : ILivingCondition, ILivingThing
    {
        public bool HasWater(string cityName)
        {
            throw new NotImplementedException();
        }

        public bool Age()
        {
            throw new NotImplementedException();
        }
    }
}
