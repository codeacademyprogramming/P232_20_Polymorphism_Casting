using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class Student:Human
    {
        public string GroupNo;

        public override string ToString()
        {
            return $"Name: {Name} - GroupNo: {GroupNo}";
        }
    }
}
