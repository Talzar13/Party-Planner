using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_Planner
{
    internal class DinnerParty
    {
        // Fields.
        public const int CostOfFoodPerPerson = 25; //Base cost of food per person.
        public int NumberOfPeople;
        public int CostOfBeveragesPerson;
        public decimal CostOfDecorations;
        

        // Properties.


        // Constructors.


        // Methods.
        public void SetHealthyOption(bool chbHealthyOptionValue)
        {
            CostOfBeveragesPerson = chbHealthyOptionValue ? 5 : 20;

        }

        public void CalculateCostOfDecorations(bool FancyDecorationsValue)
        {
            CostOfDecorations = FancyDecorationsValue ? (15m * NumberOfPeople) + 50 : (7.5m * NumberOfPeople) + 30;
        }

        public decimal CalculateCost(bool HealthyOption)
        {

            decimal totalCosts = ((CostOfFoodPerPerson + CostOfBeveragesPerson) * NumberOfPeople) + CostOfDecorations;
            if (HealthyOption)
            {
                return totalCosts * .95m;
            }
            else
            {
                return totalCosts;
            }
        }

    }
}
