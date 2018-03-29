using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInheritance

{
    public class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople{get; set;}
        public bool FancyDecorations {get;set;}
        public decimal CakeSize { get; set; }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, decimal cakeSize)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeSize = cakeSize;
        }
    }
}
