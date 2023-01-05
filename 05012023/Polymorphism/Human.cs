using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class Human
    {
        public string Name;

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}
