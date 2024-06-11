using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance2
{
    internal class Admin : User
    {
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }

        public Admin(string univer, string fio) : base(univer, fio)
        {
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }

        public void AddTeacher(Teacher teacher)
        {
            if (!Teachers.Contains(teacher))
            {
                Teachers.Add(teacher);
                Console.WriteLine($"Teacher {teacher.Fio} added to database");
            }
            else
                Console.WriteLine($"The teacher {teacher.Fio} is already in the database");

        }
        public void DeleteTeacher(string fio)
        {
            bool flag = false;
            foreach (Teacher t in Teachers)
            {
                if (t.Fio == fio)
                {
                    Teachers.Remove(t);
                    flag = true;
                    Console.WriteLine($"Teacher {fio} removed from the database");
                    break;
                }
            }
            if (!flag)
                Console.WriteLine("Teacher is not found.");
        }

        public void AddTeacherSubject(string fio, string subject)
        {
            bool flag = false;
            foreach (Teacher t in Teachers)
            {
                if (t.Fio == fio)
                {
                    t.AddSubject(subject);
                    flag = true;
                    Console.WriteLine($"An item \'{subject}\' has been added to teacher {fio}");
                    break;
                }
            }
            if (!flag)
                Console.WriteLine("Teacher is not found.");
        }

        public void DeleteTeacherSubject(string fio, string subject)
        {
            bool flag = false;
            foreach (Teacher t in Teachers)
            {
                if (t.Fio == fio)
                {
                    t.DeleteSubject(subject);
                    flag = true;
                    Console.WriteLine($"Teacher {fio} subject \'{subject}\' has been removed");
                    break;
                }
            }
            if (!flag)
                Console.WriteLine("Teacher is not found.");
        }



        public void AddStudent(Student student)
        {
            if (!Students.Contains(student))
            { 
                Students.Add(student);
                Console.WriteLine($"Student {student.Fio} added to database");
            }
            else
                Console.WriteLine($"The student {student.Fio} is already in the database");

        }

        public void DeleteStudent(string fio)
        {
            bool flag = false;
            foreach (Student stud in Students)
            {
                if (stud.Fio == fio)
                {
                    Students.Remove(stud);
                    flag = true;
                    Console.WriteLine($"Student{fio} removed from the database");
                    break;
                }
            }
            if (!flag)
                Console.WriteLine("Student is not found.");
        }

        public void AddStudentSubject(string fio, string subject, int grade)
        {
            bool flag = false;
            foreach (Student stud in Students)
            {
                if (stud.Fio == fio)
                {
                    stud.AddSubject(subject, grade);
                    Console.WriteLine($"An item \'{subject}\' has been added to student {fio}");
                    flag = true;
                    break;
                }
            }
            if (!flag)
                Console.WriteLine("Student is not found.");
        }

        public void DeleteStudentSubject(string fio, string subject)
        {
            bool flag = false;
            foreach (Student stud in Students)
            {
                if (stud.Fio == fio)
                {
                    stud.DeleteSubject(subject);
                    Console.WriteLine($"Teacher {fio} subject \'{subject}\' has been removed");
                    flag = true;
                    break;
                }
            }
            if (!flag)
                Console.WriteLine("Student is not found.");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            foreach (var t in Teachers)
            {
                Console.WriteLine($"TeacherName: {t.Fio}");
            }
            foreach (var stud in Students)
            {
                Console.WriteLine($"StudentName: {stud.Fio}");
            }
        }
    }
}
