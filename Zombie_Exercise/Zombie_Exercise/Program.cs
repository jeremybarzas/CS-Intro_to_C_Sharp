using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombie_Exercise
{
    class Entity
    {
        // fields
        private int health;
        private int attackPower;
        private string name;
        
        // Properties
        public int Health
        {
            get { return health; }

            set { health = value; }
        }

        public int AttackPower
        {
            get { return attackPower; }

            set { attackPower = value; }
        }

        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        // default constructor
        public Entity() { }

        // parameter constructor
        public Entity(int h, int att)
        {
            health = h;
            attackPower = att;
        }

        // attack function
        public virtual bool Attack(Entity e)
        {
            e.Health -= AttackPower;
            Console.WriteLine(this.name + " ATTACKED "+ e.name + " for " + AttackPower + "\n");
            return true;
        }
    }

    class Player : Entity
    {
        public Player() { }
        public Player(int h, int att)
        {
            Name = "PlayaPlaya";
            Health = h;
            AttackPower = att;
        }

        public override bool Attack(Entity e)
        {
            Console.WriteLine("For Athel Loren!!!!");
            base.Attack(e);
            return true;
        }

        public bool Defend()
        {
            return true;
        }
    }

    class Zombie : Entity
    {
        public Zombie() { }
        public Zombie(int h , int att)
        {
            Name = "Zombie";
            Health = h;
            AttackPower = att;
        }

        public override bool Attack(Entity e)
        {
            Console.WriteLine("Brains!!");
            base.Attack(e);
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player(100, 10);

            List<Zombie> zombies = new List<Zombie>();

            for (int i = 1; i <= 5; i++)
            {
                zombies.Add(new Zombie(10, i * 5));
            } 

            foreach (var z in zombies)
            {
                z.Attack(player);
                player.Attack(z);

                Console.WriteLine(player.Name + "'s remaining  health is: " + player.Health + "\n");
                Console.WriteLine(z.Name + "'s remaining  health is: " + z.Health + "\n");
            }

            Console.ReadLine();
        }
    }
}