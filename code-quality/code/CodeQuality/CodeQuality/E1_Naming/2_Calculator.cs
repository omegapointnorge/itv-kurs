using System;

namespace CodeQuality.E1_Naming
{
    public class Calculator_2
    {
        public double Calculate(double input)
        {
            // Incoming price
            var x1 = input;
            // MVA
            var y1 = input * 0.25;
            // PriceWithMva
            var res = x1 + y1;

            return res;
        }
    }

}
