using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Classroom
    {
        private static int _id;
        public int Id { get; set; }
        public string ClassName { get; set; }
        public ClassroomType ClassroomType { get; set; }

        Classroom[] Classrooms = new Classroom[] { };

        public Classroom(string className, ClassroomType classType)
        {
            _id++;
            Id = _id;
            ClassName = className;
            ClassroomType = classType;

            if (classType == ClassroomType.Backend)
            {
                Array.Resize(ref Classrooms, 20);
            }
            else if (classType == ClassroomType.FrontEnd)
            {
                Array.Resize(ref Classrooms, 15);
            }


        }

        public Classroom()
        {
        }

        public void ClassroomAdd(Classroom classroom, ClassroomType classType)
        {
            Array.Resize(ref Classrooms, Classrooms.Length + 1);
            Classrooms[Classrooms.Length - 1] = classroom;

        }
        public override string ToString()
        {
            return $" Id:{Id}\n Name:{ClassName}\n ClassType:{ClassroomType}";

        }
        public Classroom[] ShowAllClass()
        {
            return Classrooms;
        }
    }
}
