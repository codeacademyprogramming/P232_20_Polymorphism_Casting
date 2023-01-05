using System;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human
            {
                Name = "Hikmet"
            };


            Console.WriteLine(human1);

            Student student1 = new Student { Name = "Abbas", GroupNo = "P123" };

            Console.WriteLine(student1);

            int num = 123;
            object numObj = num;
            int newNum = (int)numObj;
            Console.WriteLine(newNum);




            string ageStr = "45";
            byte ageByte = 45;
            int ageInt = 511;


            ageByte = (byte)ageInt;
            //ageByte = Convert.ToByte(ageInt);

            Console.WriteLine(ageByte);

        }
    }
}
