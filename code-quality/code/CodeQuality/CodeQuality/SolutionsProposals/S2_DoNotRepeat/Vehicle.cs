using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.S2_DoNotRepeat
{

    public class Vehicle
    {

        public string Manufacturer { get; set; }
        public string ModelName { get; set; }
        public string ModelNr { get; set; }
        public DateTime FirstTimeDelivery { get; set; }

        public string GetFirstTimeDeliveryInfo()
        {
            return "The car was delivered to its first owner on " + new ProductStringFormatter().DateWrittenAsMonthByLetters(FirstTimeDelivery);
        }
    }

    public class ProductStringFormatter
    {
        public string DateWrittenAsMonthByLetters(DateTime inputDate)
        {
            var dateToStringHelper = new DateToStringHelper();
            var monthString = dateToStringHelper.GetMonthAsString(inputDate);
            var dateString = $"{inputDate.Day}. {monthString} {inputDate.Year}";

            return dateString;
        }
    }

    public class DateToStringHelper
    {
        public string GetMonthAsString(DateTime inputDate)
        {

            switch (inputDate.Month)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "";
            }
        }
    }
  
}
