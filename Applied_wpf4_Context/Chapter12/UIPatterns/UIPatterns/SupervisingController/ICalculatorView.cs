using System;

namespace UIPatterns.SupervisingController
{
    public interface ICalculatorView
    {
        CalculatorModel Model { get; set; }

        void Calculate(object sender, EventArgs args);
    }
}