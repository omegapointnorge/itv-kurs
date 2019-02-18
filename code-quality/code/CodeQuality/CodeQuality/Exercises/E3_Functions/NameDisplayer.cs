using System.Linq;

namespace CodeQuality.E3_Functions
{
    public class NameDisplayer
    {

        public string FormatName(string firstName, string middleName, string lastName, Gender gender, bool lastNameAsCapitalized, bool shortenMiddleName, bool prefixWithTitle)
        {

            var result = "";

            if (prefixWithTitle)
            {
                if (gender == Gender.Woman)
                {
                    result += "Ms. ";
                }
                if (gender == Gender.Man)
                {
                    result += "Mr. ";
                }
            }

            result += firstName;

            if (!string.IsNullOrWhiteSpace(middleName))
            {

                result += shortenMiddleName ? $"{middleName.First()}. " : middleName + " ";
            }

            result += lastNameAsCapitalized ? lastName.ToUpper() : lastName;

            return result;

        }

    }
}
