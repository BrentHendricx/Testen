using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class ActionDelegate
    {
        Action<Student> PrintStudentDetail = s => Console.WriteLine($"Name: {0}, Age: {1}", s.StudentName, s.Age);
        Student std = new Student() { StudentName = "Bill", Age = 21 };
        PrintStudentDetail(std); //output:    Name:Bill, Age:21
    }
    class Student
    {

    }
}
