using System;

namespace StudentClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Student Object ");

            Student student1 = new Student("Chris", 10);

            Console.WriteLine($"Name           : {student1.Name}");
            Console.WriteLine($"Age            : {student1.Age}");
            Console.WriteLine($"School         : {Student.SchoolName}");
            Console.WriteLine($"Student Id     : {student1.StudentId}");

            Console.WriteLine();

            Console.WriteLine(" Constructor Chaining ");

            Student student2 = new Student("Rahul");

            Console.WriteLine($"Name : {student2.Name}");
            Console.WriteLine($"Age  : {student2.Age}");

            Console.WriteLine();

            Console.WriteLine(" Method Overloading ");

            Console.WriteLine(student1.CalculateGrade(95));
            Console.WriteLine(student1.CalculateGrade(85, 90));

            Console.WriteLine();

            Console.WriteLine(" Validation Example ");

            try
            {
                Student student3 = new Student("Kumar", 120);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            Console.WriteLine(" Const vs Readonly ");

            Console.WriteLine($"Const (School Name) : {Student.SchoolName}");
            Console.WriteLine($"Readonly (Student Id): {student1.StudentId}");

            // These lines will cause compile-time errors if uncommented

            // Student.SchoolName = "ABC School";
            // student1.StudentId = Guid.NewGuid();

            Console.ReadKey();
        }
    }

    class Student
    {
        // const -> Must be assigned here and can never change
        public const string SchoolName = "ABC Public School";

        // readonly -> Can only be assigned here or inside a constructor
        public readonly Guid StudentId;

        private int age;

        public string Name { get; set; }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 5 || value > 100)
                {
                    throw new ArgumentException("Age must be between 5 and 100.");
                }

                age = value;
            }
        }

        // Constructor
        public Student(string name, int age)
        {
            StudentId = Guid.NewGuid();

            Name = name;
            Age = age;
        }

        // Constructor Chaining
        public Student(string name)
            : this(name, 18)
        {
        }

        // Overloaded Method
        public string CalculateGrade(int marks)
        {
            if (marks >= 90)
                return "Grade A";

            if (marks >= 80)
                return "Grade B";

            return "Grade C";
        }

        // Overloaded Method
        public string CalculateGrade(int internalMarks, int externalMarks)
        {
            int total = (internalMarks + externalMarks) / 2;

            return CalculateGrade(total);
        }
    }
}