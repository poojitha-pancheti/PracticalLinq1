using System;
using System.Globalization;
using System.Threading;

namespace LinqProject
{
    public static class StringExtensions
    {
       public static string ConvertToTitleCase(string source)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(source);
        }
    }
}
