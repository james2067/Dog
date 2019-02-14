using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogProgram
{
    enum Gender { Male, Female };

    class Dog
    {
        public Dog(String nameX, String ownerX, int ageX, Gender genderX)
        {
            name = nameX;
            owner = ownerX;
            ageX = ageX;
            gender = genderX;
        }
        public String name;
        public String owner;
        public int age;
        public Gender gender;

        public void bark(int barks)
        {
            for(int i=0;i<barks;i++)
            {
                Console.WriteLine("Woof!");
            }
        }
        
        public String getTag()
        {
            String tag = "";
            if(gender == Gender.Male && age <= 1)
            {
                tag = "If lost, call " + owner + ". His name is " + name + " and he is " + age + " years old.";
            }
            else if(gender == Gender.Male && age >1)
            {
                tag = "If lost, call " + owner + ". His name is " + name + " and he is " + age + " years old.";
            }
            else if(gender == Gender.Female && age <= 1)
            {
                tag = "If lost, call " + owner + ". Her name is " + name + " and she is " + age + " years old.";
            }
            else if(gender == Gender.Female && age > 1)
            {
                tag = "If lost, call " + owner + ". Her name is " + name + " and she is " + age + " years old.";
            }
            return tag;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);
            puppy.bark(3);
            Console.WriteLine(puppy.getTag());

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);
            myDog.bark(1);
            Console.WriteLine(myDog.getTag());
            Console.ReadLine();
        }
    }
}
