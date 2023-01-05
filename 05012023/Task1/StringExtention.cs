using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal static class StringExtention
    {
        public static bool HasDigit(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    return true;
            }

            return false;
        }

        public static string FixSpace(this string str)
        {
            StringBuilder sb = new StringBuilder();

            int spaceCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    sb.Append(str[i]);
                    spaceCount = 0;
                }
                else if (spaceCount == 0)
                {
                    sb.Append(str[i]);
                    spaceCount++;
                }
            }

            return sb.ToString();
        }
    }
}
