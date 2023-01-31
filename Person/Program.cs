using System.Runtime.CompilerServices;

namespace Person
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        

        public string FirstName
        {
            get => firstName;
            set => firstName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Age
        {
            get => age;
            set => age = 
                value <= 0 ? throw new Exception("Age cannot be zero or negative") : value;
        }

        public decimal Salary
        {
            get => salary;
            set => salary = 
                value < 460 ? throw new Exception("salary cannot be less than 460") : value;
        }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public void Increasesalary(decimal percentage) 
            => salary += age > 30 ? (salary * percentage / 100): (salary * percentage / 200);

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old and salary is {this.Salary}";
        }
    }

    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reverseTeam;

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reverseTeam = new List<Person>();
        }

        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get => this.firstTeam.AsReadOnly();
        }

        public IReadOnlyCollection<Person> ReverseTeam
        {
            get => this.reverseTeam.AsReadOnly();
        }

        public void AddPlayer(Person p)
        {
            if (p.Age < 40) firstTeam.Add(p);
            else reverseTeam.Add(p);
        }
    }

    public class Program
    {
        // demo 1, 2, 3, 4
        /*static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string firstName, lastName, age;
                Console.WriteLine("--------------------------------");
                Console.Write("First name: ");
                firstName = Console.ReadLine();
                Console.Write("Last name: ");
                lastName = Console.ReadLine();
                Console.Write("Age: ");
                age = Console.ReadLine();
                Console.Write("Salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());
                Person p = new Person(firstName, lastName, Convert.ToInt32(age), salary);
                people.Add(p);
            }
            
            foreach (Person p in people)
            {
                p.Increasesalary(50);
                Console.WriteLine(p.ToString());
            }
            SortPeopleByFirstName(people);
        }

        public static void SortPeopleByFirstName(List<Person> pList)
        {
            var sorted =
                pList.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, sorted));
        }*/

        static void Main()
        {
            Team team1 = new Team("Team 1");
            var n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string firstName, lastName, age;
                Console.WriteLine("--------------------------------");
                Console.Write("First name: ");
                firstName = Console.ReadLine();
                Console.Write("Last name: ");
                lastName = Console.ReadLine();
                Console.Write("Age: ");
                age = Console.ReadLine();
                Console.Write("Salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());
                Person p = new Person(firstName, lastName, Convert.ToInt32(age), salary);
                team1.AddPlayer(p);
            }

            var firstTeam = team1.FirstTeam;
            Console.WriteLine("Team 1");
            foreach (var mem in firstTeam)
            {
                Console.WriteLine(mem.ToString());
            }

            Console.WriteLine("--------------------------------" +
                              "\nTeam 2");
            var reverseTeam = team1.ReverseTeam;
            foreach (var mem in reverseTeam)
            {
                Console.WriteLine(mem.ToString());
            }
        }
    }
}