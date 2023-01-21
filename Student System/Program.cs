using System.ComponentModel.Design;

namespace StudentSystem
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Grade { get; set; }
        public Student(){}

        public Student(string name, int age, decimal grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}" +
                              $"\nAge: {Age}" +
                              $"\nGrade: {Grade}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> stList = new List<Student>();
            while (true)
            {
                MenuCommand();
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreateStudent(stList);
                        break;
                    case 2:
                        ShowAStudentName(stList);
                        break;   
                    case 3:
                        ShowAllStudent(stList);
                        break;
                }

                if (choice == 4) break;
            }
        }

        public static void MenuCommand()
        {
            Console.WriteLine("1. Create new student");
            Console.WriteLine("2. Show a student's name");
            Console.WriteLine("3. Show list of students");
            Console.WriteLine("4. Exit");
        }

        public static void CreateStudent(List<Student> stList)
        {
            Student student = new Student();
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Grade: ");
            decimal grade = decimal.Parse(Console.ReadLine());
            student.Name = name;
            student.Age = age;
            student.Grade = grade;
            stList.Add(student);
        }

        public static void ShowAStudentName(List<Student> stList)
        {
            Console.WriteLine("Enter the name of the student");
            string name = Console.ReadLine();
            foreach (Student student in stList)
            {
                if (student.Name == name)
                {
                    student.Show();
                }
            }
        }

        public static void ShowAllStudent(List<Student> stList)
        {
            foreach (Student student in stList)
            {
                student.Show();
            }
        }
    }
}