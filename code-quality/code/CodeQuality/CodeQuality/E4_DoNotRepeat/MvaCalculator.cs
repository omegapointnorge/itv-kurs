using System;
using System.Collections.Generic;
using System.Text;

namespace CodeQuality.E4_DoNotRepeat
{
    public class MvaCalculator
    {

        public double AddMvaToPrice(double priceWithoutMva, Industry industry)
        {

            var priceWithMva = 0d;

            switch (industry)
            {
                case Industry.General:
                    var g1 = priceWithoutMva;
                    var g2 = priceWithoutMva * 0.25;
                    priceWithMva = g1 + g2;
                    break;
                case Industry.Sales:
                    var s1 = priceWithoutMva;
                    var s2 = priceWithoutMva * 0.20;
                    priceWithMva = s1 + s2;
                    break;
                case Industry.Industry:
                    var i1 = priceWithoutMva;
                    var i2 = priceWithoutMva * 0.10;
                    priceWithMva = i1 + i2;
                    break;
                case Industry.Travel:
                    var t1 = priceWithoutMva;
                    var t2 = priceWithoutMva * 0.15;
                    priceWithMva = t1 + t2;
                    break;
                default:
                    break;
            }

            return priceWithMva;
        }



    }
}
