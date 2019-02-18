using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.E1_Readability.Helpers
{
    public class GradeCalculator
    {
        public double GetExtraCreditForSubject(int subjectId)
        {
            switch (subjectId)
            {
                case 1:
                    return 1;
                case 2:
                    return 0.5;
                case 3:
                    return 0;
                case 4:
                    return 0;
                case 5:
                    return 1;
                default:
                    return 0;
            }

        }

    }
}
