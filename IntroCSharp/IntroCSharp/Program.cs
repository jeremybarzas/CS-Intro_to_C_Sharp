using System; // Console.WriteLine() // Console.ReadLine()
using System.Collections.Generic; // List
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp
{   class Dude
    {
        // fields
        private int health;
        private int armor;
        private int strength;
    
        // Properties
        public int Health
        {
            get { return health; }

            set { health = value; }
        }

        // default  constructor
        public Dude() { }

        // parameter constructor
        public Dude(int h, int a, int s)
        {
             health = h;
             armor = a;
             strength = s;
        }

        // attack function
        public int Attack(Dude defender)
        {
            return defender.health = this.strength - defender.armor;
        }
    }

    class Student
    {
        private int id;
        public Student() { }

        public Student(int i)
        {
            id = i;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int number1 = 1;
            int number2 = 2;
            int number3 = 0;

            number3 = number1 + number2;

            Console.Write(number3);

            Dude dude1 = new Dude(200, 25, 75);
            Dude dude2 = new Dude(200, 50, 50);

            dude1.Attack(dude2);

            dude1.Health = 1000;

            List<Student> students = new List<Student>();

            for (int i = 1; i <= 10; i++)
            {
                students.Add(new Student(i));    
            }
            
            Console.WriteLine(students[0].ToString());

            Console.ReadLine();
        }
    }
}