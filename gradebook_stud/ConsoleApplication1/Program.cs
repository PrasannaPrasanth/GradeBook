using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gradebook_stud;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            stud_sub studsub = new stud_sub();
            Console.WriteLine("Enter student Id:");
            int id =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student age:");
            int age =Convert.ToInt32(Console.ReadLine());

            Student s1 = new Student(id, name, age);

            studsub.Stud = s1;

            Console.WriteLine("Enter first subjectname:");
            string sub1 = Console.ReadLine();
            Console.WriteLine("Enter second subjectname");
            string sub2 = Console.ReadLine();
            Console.WriteLine("Enter" + sub1 + "mark:");
            int sub1mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter" + sub2 + "mark:");
            int sub2mark = Convert.ToInt32(Console.ReadLine());

            studsub.Sub.Add(new Subject(sub1, sub1mark));
            studsub.Sub.Add(new Subject(sub2, sub2mark));

            Console.WriteLine(studsub);
        }
    }
}
