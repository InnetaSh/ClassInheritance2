using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance2
{
    internal class Student :User
    {
        public string Faculty { get; set; }
        public Dictionary<string, int> AcademicPerformance;

        public Student(string univer, string fio, string faculty) :base(univer, fio)
        {
            Faculty = faculty;
            AcademicPerformance = new Dictionary<string, int>();
        }
        public void AddSubject( string subjectName, int grade)
        {
            AcademicPerformance.Add(subjectName, grade);

        }

        public void DeleteSubject(string subjectName)
        {
            AcademicPerformance.Remove(subjectName);

        }

        public void SetGrade(string subjectName, int grade)
        {
            bool flag = false;
            foreach (var key in AcademicPerformance.Keys)
            {
                if (key == subjectName)
                {
                    AcademicPerformance[key] = grade;
                }
                flag = true;
                break;
            }
            if (!flag)
                Console.WriteLine("Subject is not found.");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Fuculty: {Faculty}");
            foreach (var key in AcademicPerformance.Keys)
            {
                Console.WriteLine($"subjectName: {key} - {AcademicPerformance[key]}");
            }
        }
    }
}
