namespace Exercises
{
    public class FunWithGenerics3
    {
        /* 
       * Now we want to add a method that will allow us to add a new element to our array. 
       * To do this, create a new method to the class called 'Add'.
       * The Add method should take a parameter of type T, add it to the end of the array, and return the new array.
       */

        public class MyVeryOwnListWithGenericAddMethod<T>
        {
            public List<T> List { get; set; }
        }
    }
}