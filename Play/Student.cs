using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play
{
    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int GradeLevel { get; set; }

        //public int CompareTo(Student other)
        public int CompareTo(Student that)
        {
            int result = this.Name.CompareTo(that.Name);
            if (result == 0)
            {
                result = this.GradeLevel.CompareTo(that.GradeLevel);
            }
            return result;

            //throw new NotImplementedException();
        }

        // Used with Hashset
        public override int GetHashCode()
        {
            return Name.GetHashCode() + GradeLevel.GetHashCode();

            //return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Student that = obj as Student;
            if (that == null)
            {
                return false;
            }
            return this.Name == that.Name  &&  this.GradeLevel == that.GradeLevel;

            //return base.Equals(obj);
        }
    }
}
