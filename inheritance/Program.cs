using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Si Dimas", 17);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Beta Pung Guru", 40, "190345", "Hacking and Carding");
            teacher.GetNameAndAge();

            Student student = new Student("Dhimas Abdillah Wicaksana", 17, "19.11.2784", "dhimas.wicaksana@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name = "no name", int age = 0)
        {
            Name = name;
            Age = age;
        }

        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name: {0} and age: {1}", Name, Age);
        }
    }

    public class Teacher : Person
    {
        
        public string TeacherId { get; set; }
        public string Subject { get; set; }

        public Teacher(string name = "no name", int age = 0, string teacherId = "no id", string subject = "no subject")
        {
            Name = name;
            Age = age;
            TeacherId = teacherId;
            Subject = subject;
        }
    }
    
    public class Student : Person
    {
        public string StudentId { get; set; }
        public string Email { get; set; }

        public Student(string name = "no name", int age = 0, string studentId = "no id", string email = "no email")
        {
            Name = name;
            Age = age;
            StudentId = studentId;
            Email = email;
        }
    }

}
