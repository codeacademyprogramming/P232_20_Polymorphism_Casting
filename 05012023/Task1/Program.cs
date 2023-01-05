using System;
using System.Text;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();



            Console.WriteLine(text.HasDigit());
            Console.WriteLine(text.FixSpace());
        }

        //Verilmis yazida her soz arasinda bir bosluq qalacaq vezyete salan metod

        //static string FixSpace(string str)
        //{
        //    string newStr = "";

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if(str[i]!=' ' || newStr[newStr.Length-1]!=' ')
        //        {
        //            newStr += str[i];
        //        } 
        //    }

        //    return newStr.TrimEnd();
        //}

        static string FixSpace(string str)
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

        static bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    return true;
            }

            return false;
        }
    }
}
