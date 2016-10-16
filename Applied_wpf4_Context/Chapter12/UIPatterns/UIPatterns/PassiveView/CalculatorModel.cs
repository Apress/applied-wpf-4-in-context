using System;

namespace UIPatterns.PassiveView
{
    public class CalculatorModel
    {
        private readonly Int32 numberA;
        private readonly Int32 numberB;

        public CalculatorModel(int numberA, int numberB)
        {
            this.numberA = numberA;
            this.numberB = numberB;
        }

        public int Calculate()
        {
            return numberA + numberB;
        }
    }
}