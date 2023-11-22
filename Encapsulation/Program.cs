using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student("Ensar", "Erturk", 484, 8);
            firstStudent.GetStudentInfo();
            firstStudent.IncreaseClass();
            firstStudent.GetStudentInfo();

            Student secondStudent = new Student("Kazim", "Karabekir", 123, 1);
            secondStudent.GetStudentInfo();
            secondStudent.DropClass();
            secondStudent.GetStudentInfo();
        }
    }

    class Student
    {
        private string name;
        private string surname;
        private int studentNo;
        private int classNo;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        public int StudentNo
        {
            get => studentNo;
            set => studentNo = value;
        }

        public int ClassNo
        {
            get => ClassNo;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("1 den dusuk deger olamaz");
                    ClassNo = 1;
                }
                else
                {
                    classNo = value;
                }
            } 
        }

        public Student()
        {
        }

        public Student(string name, string surname, int studentNo, int className)
        {
            this.name = name;
            this.surname = surname;
            this.studentNo = studentNo;
            this.classNo = className;
        }

        public void GetStudentInfo()
        {
            Console.WriteLine("****************");
            Console.WriteLine("Student Name : {0}", this.name);
            Console.WriteLine("Student Surname : {0}", this.surname);
            Console.WriteLine("Student No : {0}", this.studentNo);
            Console.WriteLine("Student ClassName : {0}", this.classNo);
        }

        public void IncreaseClass()
        {
            this.classNo = this.classNo + 1;
        }
        
        public void DropClass()
        {
            this.classNo = classNo - 1;
        }
    }
}
