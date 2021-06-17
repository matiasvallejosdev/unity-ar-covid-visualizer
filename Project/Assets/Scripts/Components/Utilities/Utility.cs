using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Utilities
{
    public static class Utility
    {
        public static string GetNumberFormat(int value, string format = "en-US")
        {
            // Gets a NumberFormatInfo associated with the en-US culture.
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;

            var val = value.ToString("N", nfi);
            var result = val.Substring(0, val.IndexOf('.', 0));

            return result;
        }
    }
}
