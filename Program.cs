using System;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Console.WriteLine("Hello User, what is your name?");
            // string name = Console.ReadLine().ToLower();
            
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            
            //Console.WriteLine("Hello " + name + "It sounds like " + name + "is " + age + "years old");
            //Console.WriteLine($"Hello {0}. It sounds like {0} is {1} years old.", name, age);
            //Console.WriteLine($"Hello {name}. It sounds like {name} is {age} years old.", name, age);

            //int myNum = 82;
            //myNum = myNum * 2;
            //myNum *= 2;
            //Console.WriteLine(15 % 12);
            // if (name.ToLower() =="patrick" && age == "30")
            // {
            //     Console.WriteLine("YOU ROCK"); //true
            // }
            // else if (name.ToLower() == "zach")
            // {
            //     Console.WriteLine("Whazzzup Bossman!!!!"); //if line 26 is true
            // }
            // else
            // {
            //     Console.WriteLine("Yo dawg I heard you like TV's");
            // }
            
            // switch(name)
            // {
            //     case "patrick":
            //         System.Console.WriteLine("you rock!");
            //         break;
            //     case "zach":
            //     case "jake":
            //         System.Console.WriteLine("yo bossman");
            //         if(name == "jake")
            //         {
            //             System.Console.WriteLine("good luck sleeping");
            //         }
            //         break;
            //     default:
            //         System.Console.WriteLine("I don't know you");
            //         break;
            // }

            int intAge = 0;


            if(Int32.TryParse(age, out intAge))
            {
                if(intAge > 21)
                {
                System.Console.WriteLine("welcome to the club");
                }
                else
                {
                    System.Console.WriteLine("Go back to school kid");
                }
            }
            else
            {
                System.Console.WriteLine("Invalid Input");
            }
            
            System.Console.WriteLine("Goodbye");
        }
    }
}