using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play
{
    class GLSort : IComparer<Student>
    {
        public string Name { get; set; }
        public int GradeLevel { get; set; }

        // Sort list by ascending grade levels
        public int Compare(Student x, Student y)
        {
            if (x.GradeLevel < y.GradeLevel)
            {
                return -1;
            }
            else if (x.GradeLevel > y.GradeLevel)
            {
                return 1;
            }
            else
            {
                return 0;
            }

            //throw new NotImplementedException();
        }
    }
}
