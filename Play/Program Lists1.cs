using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Try debugger
using System.Diagnostics;

namespace Play
{
    class ProgramLists1
    {
        static void MainLists1(string[] args)
        {
            /*  *****   Lists   *****   */

            // List of indeterminate size:
            Console.WriteLine("students");
            List<string> students = new List<string>();
            students.Add("Sue");
            Console.WriteLine(students.Count + " " + students.Capacity);

            students.Add("Bob");
            students.Add("Bill");

            Console.WriteLine(students.Count + " " + students.Capacity);
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }

            students.Add("Bilbo");
            students.Add("Frodo");
            Console.WriteLine(students.Count + " " + students.Capacity);

            // List of definite size:
            Console.WriteLine("\nplayers");
            List<string> players = new List<string>(500);
            Console.WriteLine(players.Count + " " + players.Capacity);

            // Instantiate:
            Console.WriteLine("\nfriends");
            List<string> friends = new List<string> { "Jimbo", "Rob", "Robert", "Tony", "Vinnie" };
            Console.WriteLine(friends.Count + " " + friends.Capacity);

            List<string> friends2 = new List<string>(5) { "Jimbo", "Rob", "Robert", "Tony", "Vinnie" };
            Console.WriteLine(friends2.Count + " " + friends2.Capacity);

            // Copy:
            List<string> friends3 = new List<string>(friends);
            Console.WriteLine(friends3.Count + " " + friends3.Capacity);
            for (int i = 0; i < friends3.Count; i++)
            {
                Console.WriteLine(friends3[i]);
            }

            // Convert to array:
            Console.WriteLine("\nstudentArray");
            string[] studentArray = students.ToArray();
            foreach (string student in studentArray)
            {
                Console.WriteLine(student);
            }

            // Insert
            Console.WriteLine("\nstudents again");
            students.Insert(1, "Gandalf");
            foreach (string student in students)
            {
                Console.Write(student + ", ");
            }

            // Remove
            Console.WriteLine("\nstudents again");
            students.RemoveAt(2);
            foreach (string student in students)
            {
                Console.Write(student + ", ");
            }

            Console.WriteLine("\nremove again");
            students.Remove("Sue");
            foreach (string student in students)
            {
                Console.Write(student + ", ");
            }

            Console.WriteLine("\n\nremove");
            students.Add("Gandalf");
            students.Add("Sam");
            foreach (string student in students)
            {
                Console.Write(student + ", ");
            }

            Console.WriteLine("\nremove");
            students.Remove("Gandalf");
            foreach (string student in students)
            {
                Console.Write(student + ", ");
            }

            Console.WriteLine("\n\nsort");
            students.Sort();
            foreach (string student in students)
            {
                Console.Write(student + ", ");
            }

            Console.ReadKey();
        }
    }
}
