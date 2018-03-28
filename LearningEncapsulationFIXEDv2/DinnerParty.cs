using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEncapsulationFIXEDv2
{
    public class DinnerParty
    {
        public int NumberOfPeople { get; set; } // This time we set up this properties when we create object, then they will be updated after we change parametrs in our program.
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public const int FoodPerPerson = 25;
        private decimal totalCost;

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations) // nowe when w crea new DinnerParty we can use parametrs (number, bool, bool)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }

        private decimal CalculateCostOfDecorations() //because we won't use this methods in Form1.cs we can make them private
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15M) + 50;
                return costOfDecorations;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.5M) + 30;
                return costOfDecorations;
            }
        }
            

        private decimal CalculateCostOfBeveragesPerPerson() 
        {
            int costOfBeveragesPerPerson;
            if (HealthyOption)
            {
                costOfBeveragesPerPerson = NumberOfPeople * 5;
                return costOfBeveragesPerPerson;
            }
            else
            {
                costOfBeveragesPerPerson = NumberOfPeople * 20;
                return costOfBeveragesPerPerson;
            }            
        }
        public decimal Cost //just black box
        { 
            get
            {
                totalCost = (NumberOfPeople * FoodPerPerson) + CalculateCostOfBeveragesPerPerson() + CalculateCostOfDecorations();
                if (HealthyOption)
                {
                    return totalCost * 0.95M;
                }
                else
                {
                    return totalCost;
                }
            }       
        }          
    }
}
