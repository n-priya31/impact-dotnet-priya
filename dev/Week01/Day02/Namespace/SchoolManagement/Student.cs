namespace SchoolManagement
{
    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Student Name: {Name}");
        }
    }
}