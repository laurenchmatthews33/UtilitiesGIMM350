//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Hello, world!");

            var meaningOfLife = 42;
            var smallPi = 3.14f;
            var bigPi = 3.14159265359;
            const bool likesPizza = true;
            string[] writers = { "Anthony", "Brian", "Eric", "Sean" };
            string[] editors = new string[5]; //this creates an array with a capacity of 5 elements - "New" is creating an instance of the array of strings
            //important when working with objects
            Console.WriteLine(writers[2]); //you will see eric's name printed in the code - this is because array's always start with zero and count on 
            //from there - so Anthony is 0, Brian is 1, and Eric is 2. 
            writers[0] = "Ray"; //this replaces the first string in the array with another string - now when the first element is accessed, it will read
                                //ray instead of anthony. 
                                //cannot remove indexes - once an array has been defined with an amout of elements, it will always contain that number of elements. If you want to 
                                //copy the array to another array, you have to create a new array and copy all of the values. 

            //control the code flows based on certain values - i.e. an if statement 
            if (likesPizza == false)
            {
                Console.WriteLine("You Monster!");
                bool isMonster = (likesPizza == true) ? false : true; //This is a condenced if statement of the one written above 
            }

            //For Loop - this loop works to initialze a variable named i, then loops 10 times, all the while incrementing i after each iteration 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("C# Rocks");
            }

            foreach (string writer in writers) //this loops through all the elements of the array and prints each element to the console. 
            {
                Console.WriteLine(writer);
            }

            if (meaningOfLife == 42)
            {
                bool inScope = true;

            }

            Point2D myPoint = new Point2D();
            myPoint.X = 10;
            myPoint.Y = 20; //the dot operater here allows us to access the properties. 

            Point2D anotherPoint = new Point2D();
            anotherPoint.X = 5;
            anotherPoint.Y = 15;

            myPoint.AddPoint(anotherPoint);

            Console.WriteLine(myPoint.X);
            Console.WriteLine(myPoint.Y);

            Point2D yetAnotherPoint = myPoint;
            yetAnotherPoint.X = 100;

            Console.WriteLine(myPoint.X);
            Console.WriteLine(yetAnotherPoint.X);

            Point2DRef pointRef = new Point2DRef();
            pointRef.X = 20;
            Point2DRef anotherRef = pointRef;
            anotherRef.X = 25;

            Console.WriteLine(pointRef.X);
            Console.WriteLine(anotherRef.X);
            pointRef = null; //makes the object no longer accesible, unless there is another reference to it. - here anotherRef is refering to pointRef so its not null

            anotherRef.X = 125;
            Console.WriteLine(anotherRef.X);
            anotherRef = null;

            RenFairePerson person = new RenFairePerson();
            person.Name = "Igor the Ratcatcher";
            person.SayHello();
        }

    }
}


struct Point2D //this defines a new object called Point2D - this isnt an object by itself, but rather a template of one. 
{
    public int X;
    public int Y;
    public void AddPoint(Point2D anotherPoint) //this method is meant to add two different points together
    {
        this.X = this.X + anotherPoint.X;
        this.Y = this.Y + anotherPoint.Y;
    }
}

class Point2DRef
{
    public int X;
    public int Y;

    public void AddPoint(Point2DRef anotherPoint)
    {
        this.X = this.X + anotherPoint.X;
        this.Y = this.Y + anotherPoint.Y;
    }
}

class Person
{
    public string Name;
    public virtual void SayHello()
    {
        Console.WriteLine("Hello");
    }
}

class RenFairePerson : Person
{
    public override void SayHello()

    {
        base.SayHello();
        Console.Write("Huzzah!");
    }

}