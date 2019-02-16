using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogassignment
{
    class Program
    {
        public enum Gender
        {
            Male,
            Female
        }


        public class Dog
        {

            static void Main(string[] args)
            {
                Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
                puppy.Bark(3); // output: Woof!Woof!Woof!
                Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

                Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
                myDog.Bark(1); // output: Woof!
                Console.WriteLine(myDog.GetTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.
                Console.ReadLine();
            }

            public string name;
            public string owner;
            public int age;
            public Gender gender;

            public Dog(string dogname, string ownername, int dogage, Gender doggender)
            {
                name = dogname;
                owner = ownername;
                age = dogage;
                gender = doggender;
            }

            public void Bark(int x)
            {
                int i;
                for (i = 0; i < x; i++)
                {
                    Console.WriteLine("Woof!");
                }
            }

            public string GetTag()
            {
                string tag;

                if (age > 1) {
                    switch (gender)
                    {
                        case Gender.Male:
                            Console.WriteLine("If lost, call {0}. His name is {1} and he is {2} years old.", owner, name, age);
                            break;
                        case Gender.Female:
                            Console.WriteLine("If lost, call {0}. Her name is {1} and she is {2} years old.", owner, name, age);
                            break;
                    }
                }
                else {
                    switch (gender)
                    {
                        case Gender.Male:
                            Console.WriteLine("If lost, call {0}. His name is {1} and he is {2} year old.", owner, name, age);
                            break;
                        case Gender.Female:
                            Console.WriteLine("If lost, call {0}. Her name is {1} and she is {2} years old.", owner, name, age);
                            break;
                    }
                }
                tag = "";
                return tag;
            }
        }
    }
}
