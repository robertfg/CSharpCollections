using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Try debugger
using System.Diagnostics;

namespace Play
{
    class ProgramLists2
    {
        static void MainLists2(string[] args)
        {
            /*  *****   Lists   *****   */

            //List<Student> students = new List<Student>();
            List<Student> students = new List<Student>
            {
                new Student() { Name = "Sally", GradeLevel = 3 },
                new Student() { Name = "Bob",   GradeLevel = 3 },
                new Student() { Name = "Sally", GradeLevel = 2 }
            };

            students.Sort();
            foreach(Student student in students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }

            /*Console.WriteLine();
            Console.WriteLine("Generic");

            GLSort glSort = new GLSort();

            students.Sort(glSort);

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }*/

            // Search
            Console.WriteLine();
            Console.WriteLine("Sorted insert");

            Student newStudent = new Student() { Name = "Joe", GradeLevel = 2 };

            int index = students.BinarySearch(newStudent);
            if (index < 0)
            {
                //students.Insert((-index)-1, newStudent);
                students.Insert(~index, newStudent);
            }

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }

            // Add to school roll:
            Console.WriteLine();
            Console.WriteLine("School roll");

            SchoolRoll schoolRoll = new SchoolRoll();
            schoolRoll.AddStudents(students);

            foreach(Student student in schoolRoll.Students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }

            Console.ReadKey();
        }
    }
}
