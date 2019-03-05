using System;
using System.Collections.Generic;
using System.Text;
using CodeQuality.E2_DoNotRepeat;

namespace CodeQuality.S2_DoNotRepeat
{
    public class MvaCalculator
    {
        public double AddMvaToPrice(double priceWithoutMva, Industry industry)
        {
            var mvaRate = 1d;
            switch (industry)
            {
                case Industry.General:
                    mvaRate = 0.25;
                    break;
                case Industry.Sales:
                    mvaRate = 0.20;
                    break;
                case Industry.Industry:
                    mvaRate = 0.10;
                    break;
                case Industry.Travel:
                    mvaRate = 0.15;
                    break;
                default:
                    break;
            }

            return priceWithoutMva + (priceWithoutMva * mvaRate);
        }
     


    }
}
