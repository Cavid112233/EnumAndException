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
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students = new List<Student>();
        public ClassroomType Type { get; set; }

        public Classroom(int id, string name, ClassroomType type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public Student FindStudentById(int id)
        {
            return Students.Find(student => student.Id == id);
        }

        public void DeleteStudent(int id)
        {
            Student student = FindStudentById(id);
            if (student != null)
            {
                Students.Remove(student);
            }
        }
    }
}
