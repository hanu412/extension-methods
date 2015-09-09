using System;

namespace ExtensionMethods.helpers
{
    internal static class StringHelper
    {
        internal static bool IsInteger(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            int result = 0;
            bool isValidInteger = int.TryParse(input, out result);
            return isValidInteger;
        }
        internal static bool IsDouble(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            double result;
            bool isValidDouble = double.TryParse(input, out result);
            return isValidDouble;
        }
        internal static bool IsDateTime(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            DateTime result;
            bool isValidDateTime = DateTime.TryParse(input, out result);
            return isValidDateTime;
        }
        internal static bool IsDecimal(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            decimal result;
            bool isValidDecimal = decimal.TryParse(input, out result);
            return isValidDecimal;
        }
    }
}
