using System;

public class Numbers
{
    public Class1()
    {
        int a = 18;
        int b = 6;
        int c = a + b;
        Console.WriteLine(c); // allows for the adding of a and b 

        // - for subtraction
        // * for multiplication 
        // / for division 

        //order of operations - similar to that math. 

        int a = 5;
        int b = 4;
        int c = 2;
        int d = a + b * c;
        Console.WriteLine(d); //this shows that the multiplication is performed before the additon. 

        //You can force another order of operations. 
        int a = 5;
        int b = 4;
        int c = 2;
        int d = (a + b) * c;
        Console.WriteLine(d);

        //another way to restructer the order of operations
        int a = 5;
        int b = 4;
        int c = 2;
        int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
        Console.WriteLine(d);

        //integer divison will always produce an integer result  even when you expect it to 
        //include a decimal or fraction. 

        //you can get the remainder in division by using the modulo operator, the % character. 
        int a = 7;
        int b = 4;
        int c = 3;
        int d = (a + b) / c;
        int e = (a + b) % c;
        Console.WriteLine($"quotient: {d}");
        Console.WriteLine($"remainder: {e}");

        //c # integer type differs from the mathmatical integer  - has a min and a max 
        int max = int.MaxValue;
        int min = int.MinValue;
        Console.WriteLine($"The range of integers is {min} to {max}");

        //if a calculation produces a value that exceeds the max or min, you are left with an overflow
        //or underflow condition. The answer appears to wrap from one limit to the other. 
        int max = int.MaxValue;
        int min = int.MinValue;
        Console.WriteLine($"The range of integers is {min} to {max}");
        int what = max + 3;
        Console.Write($"An example of overflow: {what}");
        //Notice that the answer is very close to the minimum (negative) integer. 
        //It's the same as min + 2. The addition operation overflowed the allowed values for integers.
        //The answer is a very large negative number because an overflow "wraps around" from the largest 
        //possible integer value to the smallest.

        //Working with a double type - the double numeric represents a double precision float number
        //floating point number is useful to represent non integral numbers that can be very large
        //or small in magnitude. 

        //double precision means that these numbers are stored using greater precision - used by 
        // by most modern computers. 

        double a = 5;
        double b = 4;
        double c = 2;
        double d = (a + b) / c;
        Console.WriteLine(d);

        //doulbe answers includes the decimal portion of the quotient. 
        double a = 19;
        double b = 23;
        double c = 8;
        double d = (a + b) / c;
        Console.WriteLine(d);

        //range of doubles is much greater than integer. 
        double max = double.MaxValue;
        double min = double.MinValue;
        Console.WriteLine($"The range of double is {min} to {max}");

        //just like in math, c# doubles can have rounding errors. 
        double third = 1.0 / 3.0;
        Console.WriteLine(third); //0.3 repeating is not the same as 1/3

        //Decimal - large range but greater precision than double. Term fixed point means that the 
        //decimal point (or bianary point) does not move. 

        decimal min = decimal.MinValue;
        decimal max = decimal.MaxValue;
        Console.WriteLine($"The range of decimal is {min} to {max}");
        //note that the range is smaller than the double. 
        //greater precision
        double a = 1.0;
        double b = 3.0;
        Console.WriteLine(a / b);

        decimal c = 1.0M;
        decimal d = 3.0M; //M suffix on the numbers is how you indicate the constat should use the 
        //decimal type. 
        Console.WriteLine(c / d);

        //Challenge write code that calculates the area of a circle whose raduis is 2.50 centimeters. 
        double radius = 2.50;
        double area = Math.PI * radius * radius;
        Console.WriteLine(area); 




    }
}


