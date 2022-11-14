using MockAssessment3;
using System.Linq;

Town town = new Town();
Farmer farmer = new Farmer();
Slacker slacker = new Slacker();

int total = farmer.Farm() + slacker.Farm();

town.Harvest(total);

int totalHunger = farmer.Hunger + slacker.Hunger;

int surviveHarvest = town.Harvest(total);
