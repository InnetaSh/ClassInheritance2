using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance2
{
    internal class Teacher : User
    {
        public string Faculty { get; set; }
        public List<string> Subjects { get; set; }

        public List<Student> Students { get; set; }

        public Teacher(string univer, string fio, string faculty) : base(univer, fio)
        {
            Faculty = faculty;
            Subjects = new List<string>();
            Students = new List<Student>();
        }

        public void AddSubject(string subjectName)
        {
            if(!Subjects.Contains(subjectName))
                Subjects.Add(subjectName);
        }
        public void DeleteSubject(string subjectName)
        {
            if (Subjects.Contains(subjectName))
                Subjects.Remove(subjectName);
        }

        public void AddStudent(Student student)
        {
            if (!Students.Contains(student))
                Students.Add(student);

        }

        public void FixStudentGrade(string fio, string subject, int grade)
        {
            bool flag = false;
            foreach (Student stud in Students)
            {
                if (stud.Fio == fio)
                {
                    stud.SetGrade(subject, grade);
                    Console.WriteLine($"Student {fio} grade was changed to {grade}."); ;
                    flag = true;
                    break;
                }
            }
            if (!flag)
                Console.WriteLine($"Student {fio} is not found.");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Fuculty: {Faculty}");
            foreach (var sub in Subjects)
            {
                Console.WriteLine($"SubjectName: {sub}");
            }
            foreach (var stud in Students)
            {
                Console.WriteLine($"StudentName: {stud.Fio}");
            }
        }
    }
}
