using System;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Human human1 = new Human { Name = "Hikmet" };

            object humanObj = human1;

            Student student1 = new Student { Name = "Abbas", GroupNo = "P123" };

            Teacher tc1 = new Teacher { Name = "Tofiq", Subject = "Design" };

            //upcasting
            Human human2 = new Student { Name = "Nermin", GroupNo = "P132" };

            //downcasting
            //Student student2 = (Student)human2;
            Student student2 = human2 as Student;


            human2 = new Human { Name = "Akif" };

            if(human2 is Student)
            {
                var std = (Student)human2;
                Console.WriteLine(std.GroupNo);
            }
            else if(human2 is Teacher)
            {
                var tc = (Teacher)human2;
                Console.WriteLine(tc.Subject);
            }
            else
            {
                Console.WriteLine($"{human2.Name} ne telebe ne de muellim deyil!");
            }



            Human human3 = new Student { Name = "Rafiq", GroupNo = "P555" };
            human3 = new Teacher { Name = "Eli", Subject = "Design" };


            Console.WriteLine(human3);
            Console.WriteLine("\n====================== Human list =========================\n");
            Human[] humans = { human1, human2, human3, student1, student2,tc1 };

            for (int i = 0; i < humans.Length; i++)
            {
                Console.WriteLine(humans[i]);
            }
        }
    }
}
