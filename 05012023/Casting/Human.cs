using System;
using System.Collections.Generic;
using System.Text;

namespace Casting
{
    internal class Human
    {
        public string Name;

        public virtual void ShowInfo()
        {
            Console.WriteLine(Name);
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
