namespace Solutions
{
    public class Plank
    {
        public int Length { get; set; }

        public Plank(int length)
        {
            Length = length;
        }

        public static Plank operator +(Plank p1, Plank p2)
        {
            return new Plank(p1.Length + p2.Length);
        }
        /*
        Implement an addition operator +, which adds to planks. Two planks are
        added by returning a new plank with Length equal to the sum of the two previous.

        Hint: public static Plank operator+ (Plank plank, Plank otherPlank)
         */








    }

}