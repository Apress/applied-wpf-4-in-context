using System;

namespace UIPatterns.PassiveView
{
    public interface ICalculatorView
    {
        int NumberA { get; set; }

        int NumberB { get; set; }

        void Calculate(object sender, EventArgs args);
    }
}