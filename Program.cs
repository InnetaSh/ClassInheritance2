using ClassInheritance2;

Student st = new Student("NGU", "Ivanov", "Maht");
st.AddSubject("Math", 80);
st.AddSubject("Algebra", 90);
st.AddSubject("Basics of geometry", 85);
st.PrintInfo();

Console.WriteLine("--------------------------------");

Student st2 = new Student("NGU", "Petrov", "Maht");
st2.AddSubject("Math3", 70);
st2.AddSubject("Algebra", 75);
st2.AddSubject("Basics of geometry", 80);
st2.PrintInfo();

Console.WriteLine("--------------------------------");

Teacher Babenko = new Teacher("NGU", "Babenko", "MahtAnaliz");
Babenko.AddSubject("Math");
Babenko.AddSubject("Math3");
Babenko.AddStudent(st);
Babenko.PrintInfo();
Babenko.FixStudentGrade("Ivanov", "Math", 100);
Babenko.FixStudentGrade("Petrov", "Math", 100);


Console.WriteLine("--------------------------------");
st.PrintInfo();
Console.WriteLine("--------------------------------");
st2.PrintInfo();
Console.WriteLine("--------------------------------");

Teacher Kurdachenko = new Teacher("NGU", "Kurdachenko", "MahtAnaliz");
Kurdachenko.AddSubject("Algebra");
Kurdachenko.AddSubject("Basics of geometry");
Kurdachenko.AddStudent(st);
Kurdachenko.AddStudent(st2);
Kurdachenko.PrintInfo();

Teacher Turchin = new Teacher("NGU", "Turchin", "Statistika");
Turchin.AddSubject("Statistika");
Turchin.AddStudent(st);
Turchin.AddStudent(st2);


Console.WriteLine("--------------------------------");
Admin admin = new Admin("NGU", "Glavatska");
admin.AddTeacher(Babenko);
admin.AddTeacher(Kurdachenko);
admin.AddTeacher(Turchin);
admin.PrintInfo();
Console.WriteLine("--------------------------------");
admin.AddTeacherSubject("Babenko", "differential levels");
admin.DeleteTeacherSubject("Babenko", "Math3");
admin.DeleteTeacher("Turchin");
admin.AddTeacher(Babenko);
admin.PrintInfo();
Console.WriteLine("--------------------------------");
Babenko.PrintInfo();
Console.WriteLine("--------------------------------");

admin.AddStudent(st);
admin.AddStudent(st2);
admin.AddStudentSubject("Ivanov", "differential levels",60);
admin.PrintInfo();
st.PrintInfo();


