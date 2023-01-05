using System;
using System.Collections.Generic;
using System.Text;

namespace Casting
{
    internal class Student:Human
    {
        public string GroupNo;

        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} {GroupNo}");
        }

        public override string ToString()
        {
            return $"{Name} {GroupNo}";
        }

    }
}
