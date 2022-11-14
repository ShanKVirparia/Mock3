using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment3
{
    public class Slacker : Villager
    {
        //Fields

        //Properties

        //Constructors
        public Slacker()
        {
            Hunger = 3;
        }

        //Method

        public override int Farm()
        {
            return 0;
        }
    }
}
