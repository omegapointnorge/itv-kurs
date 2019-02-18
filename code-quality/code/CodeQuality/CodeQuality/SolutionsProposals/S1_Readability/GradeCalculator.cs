namespace CodeQuality.S1_Readability.Helpers
{
    public class GradeCalculator
    {
        public double GetExtraCreditForSubject(int subjectId)
        {
            switch (subjectId)
            {
                case SubjectConstants.Spanish:
                    return 1;
                case SubjectConstants.English:
                    return 0.5;
                case SubjectConstants.Math:
                    return 0;
                case SubjectConstants.Biology:
                    return 0;
                case SubjectConstants.Chemistry:
                    return 1;
                default:
                    return 0;
            }

        }
    }

    public static class SubjectConstants
    {
        public const int Spanish = 1;
        public const int English = 2;
        public const int Math = 3;
        public const int Biology = 4;
        public const int Chemistry = 5;
    }
}
