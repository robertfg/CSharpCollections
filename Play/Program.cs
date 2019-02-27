using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Try debugger
using System.Diagnostics;

namespace Play
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  *****   Sets    *****   */

            // Hashset (List also works)
            //List<Student> students = new List<Student>
            HashSet<Student> students = new HashSet<Student>
            {
                new Student() { Name = "Sally", GradeLevel = 3 },
                new Student() { Name = "Bob",   GradeLevel = 3 },
                new Student() { Name = "Sally", GradeLevel = 2 }
            };

            /*HashSet<Student> students = new HashSet<Student>(new List<Student>
            {
                new Student() { Name = "Sally", GradeLevel = 3 },
                new Student() { Name = "Bob",   GradeLevel = 3 },
                new Student() { Name = "Sally", GradeLevel = 2 }
            });*/

            /*SchoolRoll schoolRoll = new SchoolRoll();

            // Add twice and see what happens: only adds once > no duplicates
            schoolRoll.AddStudents(students);
            schoolRoll.AddStudents(students);

            foreach (Student student in schoolRoll.Students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }*/

            Student joe = new Student() { Name = "Joe", GradeLevel = 2 };
            students.Add(joe);

            /* Although the objects contain the same data, they're still distinct so duplicateJoe gets added
             * unless you override the GetHashCode and Equals methods.
             */
            Student duplicateJoe = new Student() { Name = "Joe", GradeLevel = 2 };
            students.Add(duplicateJoe);

            Console.WriteLine(joe.GetHashCode());
            Console.WriteLine(duplicateJoe.GetHashCode());

            if (students.Contains(joe))
            {
                // whatever
            }

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }

            Console.ReadKey();
        }
    }
}
