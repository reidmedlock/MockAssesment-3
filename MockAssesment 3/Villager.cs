using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssesment_3
{
     abstract class Villager 
    {
        public int Hunger
        {
            get; set;
        }
       

        abstract int Farm()
        {
            return 0;
        }
    };
}
