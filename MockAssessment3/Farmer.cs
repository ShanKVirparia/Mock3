using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment3
{
    public class Farmer : Villager
    {
        //Fields

        //Properties
       
        //Constructors

        public Farmer()
        {
            Hunger = 1;
        }
        //Method

        public override int Farm()
        {
            return 2;
        }
    }
}
