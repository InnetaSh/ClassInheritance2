using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Вам необходимо разработать систему управления учебным процессом. В этой системе будут участвовать три типа пользователей:
//    студент, преподаватель и администратор. Все эти типы пользователей должны наследовать базовый класс User



namespace ClassInheritance2
{
    internal class User
    {
        public string Univer { get; set; }
        public string Fio { get; set; }

        public User(string univer,string fio)
        {
            Univer = univer;
            Fio = fio;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Univer: {Univer}\nName: {Fio}");
        }
    }
}
