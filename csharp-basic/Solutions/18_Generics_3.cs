namespace Solutions
{
    public class FunWithGenerics3
    {
        /* 
       * Now add a method Add that takes a parameter of type T, adds it at the end of the array of T, and returns the new array.
       * HINT: You will need a temporary variable to hold your existing array.
       */

        public class MyVeryOwnListWithGenericAddMethod<T>
        {
            public List<T> List { get; set; }

            public List<T> Add(T addThis)
            {
                List.Add(addThis);
                return List;
            }
        }
    }

}