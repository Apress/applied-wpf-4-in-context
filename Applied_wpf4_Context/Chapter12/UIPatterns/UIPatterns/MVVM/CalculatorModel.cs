using System;

namespace UIPatterns.MVVM
{
    public class CalculatorModel
    {

        public CalculatorModel()
        {
        }

        public int Calculate()
        {
            return NumberB + NumberA;
        }

        public int NumberA { get; set; }

        public int NumberB { get; set; }
    }
}