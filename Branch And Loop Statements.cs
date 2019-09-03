using System;

public class BranchandLoops
{
	public Class1()
	{

        int a = 5;
        int b = 6;
        if (a + b > 10) 
            Console.WriteLine("The answer is greater than 10");
        //stating that if 5 plus 6 is greater than ten, "The answer is greater than 10" will appear 
        //in the output. 

        //Modify b so that the sum is less than 10 
        int a = 5;
        int b = 3;
        if (a + b > 10)
            Console.WriteLine("The answer is greater than 10");

        //the above both show the power of boolean types. A boolean is a variable that can have 
        //either a true or false value. The if statement checks the value of a bool. When the value 
        //is true, the statement following the if executes. If the statement is false, the statement
        //does not execute. 

        //to excute different bode in both the true and false breanches, you create an else branch, 
        //that executes when the condition is false. 

        int a = 5;
        int b = 3;
        if (a + b > 10)
            Console.WriteLine("The answer is great than 10"); 
        else
            Console.WriteLine("The answer is less than 10");

        //because indentation is not significant, { and } must be used when you want one or more
        //statement to be a part of the block that executes conditionally. 

        int a = 5;
        int b = 3;
        if (a + b > 10)
        {
            Console.WriteLine("The answer is great than 10");
        }
        else
        {
            Console.WriteLine("The answer is less than 10");
        }

        //more complicated conditions. 
        int a = 5;
        int b = 3;
        int c = 4; 
        if ((a + b + c >10) || (a == b))
        {
            Console.WriteLine("The answer is greater than 10");
            Console.WriteLine("And the first number is equal to the second"); 
        }
        else
        {
            Console.WriteLine("The answer is not greater than 10");
            Console.WriteLine("or the first number is not equzl to the second");
        }

        //use loops to repeat operations. 
        int counter = 0; 
        while (counter > 10)
        {
            Console.WriteLine($"Hello World!The counter is {counter}");
            counter++;
        }//The while statement checks a condition and executes the statement following the while. 
        //it will repeat checking the condition and executing those statements until the condition 
        //is false. 
        //the ++ after the counter variable is the increment operator. it adds 1 to the value of counter 
        //and stores that value in the counter variable. 

        //make sure that the while loop condition does not switch to galse as you execute the code. Otherwise
        //it creates an infinate loop where the program never ends. 

        //The while loop tests the condition before executing the code following the while. The do... while loop
        //executes the code first and then checks the condition. 

        int counter = 0;
        do
        {
            Console.WriteLine($"Hello World! The counter is {counter}");
            counter++;
        } while (counter < 10); //this is a do - wokrs the same as a while loop. 

        //Working with the For Loop - does the same work as the while loop. The for statement has three parts
        //For initializer - int counter = 0; - declares that the loop is a variable and sets its initial value to 0
        //For condition (middle part) counter < 10 declares that the for loop continues to execute as long as the 
        //value of the counter is less than 10. 
        //Final part is the for iterator - counter++ - specifies how to modify the loop variable after executing the 
        //block following the for statement. Here is specifies that the counter should be incrememented by 1 each time
        //the block executes. 

        //Challenge - write a code to find the sum of all integers 1 through 20 that are divisible by 3. Hints: 
        //the % operator gives you the remainder of a division operation 
        //the if statement give you the condition to see if a number could be a part of the sum 
        //the for loop can help you repeat a series of steps for all the numbers 1 through 20 

        int sum = 0; 
        for (int number = 1; number < 21; number++)
        {
            if (number % 3 == 0)
            {
                sum = sum + number; 
            }
        }
        Console.WriteLine($"the sum is {sum}");

        int sum = 0; 
        for (int number = 1; number < 72; number++)
        {
            if (number % 3 == 0)
            {
                sum = sum + number; 
            }
        }
        Console.WriteLine($"the sum is {sum}");
    }
}
