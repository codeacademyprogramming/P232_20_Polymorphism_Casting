using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class Teacher:Human
    {
        public string Subject { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} - Subject: {Subject}";
        }
    }
}
