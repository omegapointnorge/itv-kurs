using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.E4_DoNotRepeat
{
    public class Vehicle
    {

        public string Manufacturer { get; set; }
        public string ModelName { get; set; }
        public string ModelNr { get; set; }
        public DateTime FirstTimeDelivery { get; set; }

        public string FirstTimeDeliveryInfo()
        {
            var year = FirstTimeDelivery.Year;
            var month = FirstTimeDelivery.Month;
            var day = FirstTimeDelivery.Day;

            var dateString = day + "." + GetNorwegianMonthAsString() + year;

            var result = "The car was delivered to its first owner on " + dateString;

            return result;
        }

        private string GetNorwegianMonthAsString()
        {

            switch (FirstTimeDelivery.Month)
            {

                case 1:
                    return "januar";
                case 2:
                    return "februar";
                case 3:
                    return "mars";
                case 4:
                    return "april";
                case 5:
                    return "mai";
                case 6:
                    return "juni";
                case 7:
                    return "juli";
                case 8:
                    return "august";
                case 9:
                    return "september";
                case 10:
                    return "oktober";
                case 11:
                    return "november";
                case 12:
                    return "desember";
                default:
                    return "";
            }
        }
    }
}
