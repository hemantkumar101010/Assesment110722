using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssesment
{
    public class Solutions
    {


        //1: Write a c# program to count the even and odd numbers in the following list. List items - 50, 65, 56, 71,81
        public static void CountEvenOdd()
        {
            List<int> numbers = new List<int>() { 50, 65, 56, 71, 81 };
            int countOdd = 0, countEven = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }

            Console.WriteLine($"In Number list even numbers are: {countEven} and odd numbers are: {countOdd}");
        }

        //2. Explain Boxing and Unboxing using code snippets.
        //Boxing converts a Value Type variable into a Reference Type variable, and Unboxing achieves the vice-versa. 

        public static void BoxingUnboxing()
        {
            //value type var
            int a = 10;

            //creating a object type and assigning value type in this (Boxing)
            Object o = a;

            //updating a value
            a = 100;

            Console.WriteLine($"after updation of value type var a ... value of var a is: {a} and object value is: {o}");

            //unboxing
            //The process of converting a Reference Type variable into a Value Type variable is known as Unboxing.
            //It is an explicit conversion process.

            int b = 10;
            Object obj = b;//Boxing

            int c = (int)obj;//unboxing

            Console.WriteLine();
            Console.WriteLine($"value of objject type obj is: {obj} and value of converted value type var c is: {c}");


        }


        // 3. Write a program to find the largest value out of 325, 750, 478.

        public static void FindLargestValue()
        {

            List<int> numbers = new List<int>() { 325, 750, 478 };

            //sorting the list to get max value easily
            numbers.Sort();
            Console.WriteLine($"Largest value of the given inputs is: {numbers.Last()}");

        }

        // 4. Write a program to prints all odd numbers between 1 and 10.

        public static void DisplayAllOddNumbers()
        {
            Console.WriteLine("All odd numbers bw 1 to 10 are:");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }

        }

        //5. Define Method overloading in c# code and how to call them (write sample syntax).
        //When more then one method have same name but have different number of arguments or different arguments types is called
        // overloaded methods

        #region overloaded methods
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        //overlaoded method
        public static double Addition(double a, double b, double c)
        {
            return a + b + c;
        }

        #endregion

        //6. Program to create an array list for Delhi, Mumbai, Kolkata, Chennai and sort them

        public static void SortListOfString()
        {
            string[] arrayOfCities = { "Delhi", "Mumbai", "Kolkata", "Chennai" };

            var list = arrayOfCities.OrderByDescending(x => x).ToList();
            list.Reverse();

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }



        }


        //9. Write a program to display all the 11 cricket players using Generic Dictionary.
        public static void DisplayCricketPlayers()
        {
          Dictionary<int, string> playerList = new Dictionary<int, string>()
         {
           { 1, "Alex hales"},
           { 2, "Maxwell"},
           { 3, "Virat"},
           { 4, "Sachin"},
           { 5, "Ms"},
           { 6, "Rohit"},
           { 7, "Rahul"},
           { 8, "Hemant"},
           { 9, "Harman"},
           { 10, "Sofiee"},
           { 11, "Mayank"}
        };

        foreach (var player in playerList)
            {
                Console.WriteLine($"Jursey number: {player.Key}, Player name: {player.Value}");
            }
        }

        // 10. Create the Student Generic List using the properties ID, Name and Age and write a LINQ query to
       // display the name of teenager students.
       public static void TeenagerStudents()
        {
             List<Students> studentList = new List<Students>()
              {
                 new Students(){Id=1,Name="Sumit",Age=20},
                  new Students(){Id=2,Name="Hemant",Age=18},
                   new Students(){Id=3,Name="Rahul",Age=17},
                    new Students(){Id=4,Name="Radhika",Age=23},
                     new Students(){Id=5,Name="Mayank",Age=30},
                      new Students(){Id=6,Name="Sonali",Age=13},
                       new Students(){Id=7,Name="Kriti",Age=12}
             
              };

           var list= studentList.Where(student => student.Age < 18).ToList();
           foreach(var student in list)
            {
                Console.WriteLine($"{student.Id} {student.Name} {student.Age}");
            }
        }



    }
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  int Age { get; set; }

    }
    //8. Write code in c# - The class Computation implements two interfaces, Addition and Multiplication having
    public class Computation: IComputation
    {
        public  int Addition()
        {

            int a, b;
            Console.WriteLine("Enter first int value");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2ed int value");
            b = Convert.ToInt32(Console.ReadLine());

            return a + b;
        }

        public  int Multiplcation()
        {
            int a, b;
            Console.WriteLine("Enter first int value");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2ed int value");
            b = Convert.ToInt32(Console.ReadLine());
            return a * b;
        }
    }

    //question no 7:
    public class mySampleClass
    {
        public int Age { get; set; } 
        public string Name { get; set; }    
        public mySampleClass()
        {
            // This is the no parameter constructor method.  
            // First Constructor
            Console.WriteLine("No args para constructor is called");
        }
        public mySampleClass(int age)
        {
            Age = age;
            Console.WriteLine("one args para constructor is called");
            // Second Constructor  
        }
        public mySampleClass(int age, string name)
        {
            // This is the constructor with two parameters.
            Age = age;
            Name = name;
            Console.WriteLine("2 args para constructor is called");
            // Third Constructor  
        }
        // rest of the class members goes here.  
    }
}
