using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Animal
    {
        //Declaring attributes
        //Get - allows access to the attributes
        //Set - sets criteria of values (IE. No numbers, etc.)
        public double height { get; set; } 
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;
        //To set customizable getter and setter
        public string Name
        {
            get { return name; }
            set { name = value; }
        } 

        //Initialize attributes by setting default values of the attributes
        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
            numOfAnimals++;
        }

        //sets the variables
        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        //static fields are for functions/methods needed but not assigned to the object itself
        static int numOfAnimals = 0;

        //get access to the status value
        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        //create an object Method
        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs, and likes to say \"{3}\" ", name, height, weight, sound);
        }


        static void Main(string[] args)
        {
            Animal spot = new Animal(15, 10, "Spot", "Woof");
            Console.WriteLine("{0} says {1}", spot.name, spot.sound);
            Console.WriteLine("Number of Animals = " + Animal.getNumOfAnimals());
            Console.WriteLine(spot.toString());

            //Create an object using an initializer
            Animal grover = new Animal
            {
                name = "Grover",
                height = 16,
                weight = 18,
                sound = "Grrr"
            };
            Console.WriteLine(grover.toString());
  
            //build object using constructor
            Dog spike = new Dog(20, 15, "Spike", "Grrr", "Chicken");
            Console.WriteLine(spike.toString());
            Console.WriteLine("Number of Animals = " + Animal.getNumOfAnimals());
        }

        //creating a subClass
        //this allows one class to inherit all attributes of the parent class
        class Dog : Animal
        {
            //Add in additional attributes specific to the subclass
            public string favFood { get; set; }

            //Initialize attributes by setting default values of the attributes
            //the base() adds in all the attributes of the parent class 
            public Dog(): base()
            {
                this.favFood = "No Favorite Food";
            }

            public Dog(double height, double weight, string name, string sound, string favFood):base (height, weight, name, sound)
            {
                this.favFood = favFood;
            }

            //Overrides the previously declared method
            new public string toString()
            {
                return String.Format("{0} is {1} inches tall, weighs {2} lbs, and likes to say \"{3}\", and eats {4}.", name, height, weight, sound, favFood);
            }
            //Polymorphism through an abstract class
        }

    }
}
