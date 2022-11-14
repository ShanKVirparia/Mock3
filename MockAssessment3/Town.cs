using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment3
{
    public class Town
    {
        //Fields

        public int harvestTotal;
        public int hunger;

        //Properties
        public List<Villager> Villagers { get; set; }
        //Constructors
        
       
        public Town(int farmer, int slacker1, int slacker2,int slacker3)
        {
            Villagers.Add(Villagers[farmer]);
            Villagers.Add(Villagers[slacker1]);
            Villagers.Add(Villagers[slacker2]);
            Villagers.Add(Villagers[slacker3]);
        }

        public Town()
        {
        }

        //Methods
        
        public int Harvest(int harvestTotal)
        {
            return harvestTotal;
        }

        public int CalcFoodConsumption(int hunger)
        {
            return hunger;
        }

        public bool SurviveTheWinter()
        {
            if (hunger <= harvestTotal)
            {
                return true;
            }
            else if (hunger > harvestTotal)
            {
                return false;
            }
            return false;
        }
    }
}
