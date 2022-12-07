﻿namespace Exercises
{
    public class OptionalParameters
    {
        private readonly int _myNumber;

        /*
         *  Make the parameter number optional, 
         *  the default value should be 0
         */
        public OptionalParameters(int number)
        {
            _myNumber = number;
        }

        /*
         * Make the lastName parameter optional, 
         * with "Olsen" as the default value
         */
        public string OptionalStringParameter(string firstName, string lastName)
        {
            return $"Hello {firstName} {lastName}";
        }

        /*
         * Try to make the first parameter optional.
         * The default value for the firstName parameter should be "Ole"          
         *
         * This will not compile since the optional parameters must be defined at the end of the parameter list, 
         * after any required parameters. Let the lastName parameter be optional as well, with "Olsen" as default value
         */
        public string CanFirstParameterBeOptional(string firstName, string lastName)
        {
            return $"Hello {firstName} {lastName}";
        }

    }
}
