using System;
using System.Collections.Generic;
using Linq.Entities;

namespace Linq.Solution
{
    public static class ThatHasSolution
    {

        /**
         * Step 1:
         * In order to have the list filtered we naturally need to have both the personList 
         * and the predicate to validate whether the person should be part of the result as
         * input parameters to the method. 
         * 
         * We then loop the list, adding the persons that pass the predicate to the result list
         * before finally returning the result. 
         * 
         * Note: The function is made static so we do not need to create a new
         * instance of ThatHasSolution in order for it to be used.
         * 
         * Method is now called as 
         *      ThatHas(personList, predicate) 
         */
        private static List<Person> ThatHas_Step1(List<Person> input, Func<Person, bool> predicate)
        {
            var result = new List<Person>();
            foreach (var person in input)
            {
                if (predicate(person))
                {
                    result.Add(person);
                }
            }
            return result;
        }

        /**
         * Step 2:
         * To achieve preferable syntax we could make use of extension methods. 
         * Take note of the this keyword for the first parameter of the function below.
         * This will change how the method is called 
         * 
         * from
         * 
         * ThatHas(personList, predicate) 
         * 
         * to  
         * 
         * personList.ThatHas(predicate)
         * 
         * Note: Extensions methods must be declared in a static context. 
         */
        private static List<Person> ThatHas_Step2(this List<Person> input, Func<Person, bool> predicate)
        {
            var result = new List<Person>();
            foreach (var person in input)
            {
                if (predicate(person))
                {
                    result.Add(person);
                }
            }
            return result;
        }

        /**
        * Step 3:
        * In order to not having to create a result array and adding elements to it 
        * we can make use of the yield return syntax. 
        * 
        * Take note that the return type of the method has changed from
        * List<Person> to IEnumerable<Person> as required for using yield return
        * 
        * Additionally, the first parameter of the method is also changed from
        * List to IEnumerable. As List already implements the IEnumerable-interface, the method can still be 
        * called in the same way. 
        */
        private static IEnumerable<Person> ThatHas_Step3(this IEnumerable<Person> input, Func<Person, bool> predicate)
        {
            foreach (var person in input)
            {
                if (predicate(person))
                {
                    yield return person;
                }
            }
        }

        /**
        * Final solution:
        * 
        * Step 3 has one major drawback. The input parameter is locked to IEnumerable of type Person and the method
        * returns the same type. This is fine for our current example, but ideally we would 
        * want to be able to use ThatHas for an IEnumerable of any type, e.g. an IEnumerable<string>. 
        * 
        * To achieve this we use will use C# Generics which makes it possible to create methods that postpone determining 
        * the type a method until it is declared in code. 
        * 
        * To create a generic method one specifies the type with a keyword, in this case TSource. 
        * 
        * Now the ThatHas-method can be used for any type as seen by examples below
        * 
        *   new List<int>() { 1, 2, 3 }.ThatHas(x => x > 2);    
        *   new List<string>() { "one", "two", "three" }.ThatHas(x => x.Length > 2);
        *   new List<Person>().ThatHas(x => x.Birthday.Year > 1992);
        */

        public static IEnumerable<TSource> ThatHas<TSource>(this IEnumerable<TSource> list, Func<TSource, bool> predicate)
        {
            foreach (var element in list)
            {
                if (predicate(element))
                {
                    yield return element;
                }
            }
        }

    }
}
