using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInheritance

{
    public class BirthdayParty
        //We create similar class to DinnerParty to show how long it takes to even copy same classes 
        //and how many changes we have to make if we wonna add something to whole program. There is easier way! Time to use Inheritance!
    { 
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public string CakeWritting { get; set; }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWritting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWritting = cakeWritting;
        }
        private int ActualLenght
        {
            get
            {
                if (CakeWritting.Length > MaxWrittingLength())
                    return MaxWrittingLength();
                else
                    return CakeWritting.Length;
            }
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 20;
            else
                return 40;
        }
        private int MaxWrittingLength()
        {
            if (CakeSize() == 20)
                return 16;
            else
                return 40;
        }
        public bool CakeWrittingTooLong
        {
            get
            {
                if (CakeWritting.Length > MaxWrittingLength())
                    return true;
                else
                    return false;
            }
        }
        private decimal CalculateCostOfDecorations() //same method like in DinnerParty class
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
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                int extraCash;
                if (CakeSize() == 20)
                    cakeCost = 40M + ActualLenght * .25M;
                else
                    cakeCost = 75M + ActualLenght * .25M;
                if (NumberOfPeople > 12)
                    extraCash = 100;
                else
                    extraCash = 0;
                return totalCost + cakeCost + extraCash;
            }
        }
    }
}