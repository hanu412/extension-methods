using ExtensionMethods.helpers;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// This method checks if the given string is an Integer.
        /// </summary>
        /// <param name="input"></param>
        /// <returns> Boolean : returns  true if the input is an integer</returns>
        public static bool IsInteger(this string input)
        {
            return StringHelper.IsInteger(input);
        }


        /// <summary>
        /// This method checks if the given string is a valid DateTime.
        /// </summary>
        /// <param name="input"></param>
        /// <returns> Boolean : returns  true if the input can be parsed to DateTime</returns>
        public static bool IsDateTime(this string input)
        {

            return StringHelper.IsDateTime(input);
        }


        /// <summary>
        /// This method checks if the given string is a valid Decimal.
        /// </summary>
        /// <param name="input"></param>
        /// <returns> Boolean : returns  true if the input can be parsed to Decimal</returns>
        public static bool IsDecimal(this string input)
        {

            return StringHelper.IsDecimal(input);
        }

        /// <summary>
        /// This method checks if the given string is a valid Double.
        /// </summary>
        /// <param name="input"></param>
        /// <returns> Boolean : returns  true if the input can be parsed to Double</returns>

        public static bool IsDouble(this string input)
        {

            return StringHelper.IsDouble(input);
        }
    }
}
