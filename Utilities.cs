using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities : MonoBehaviour
{
    // Start is called before the first frame update
    public static string ProcessText(string textIn)
    {

        double number;
        double.TryParse(textIn, out number);

        if (double.TryParse(textIn, out number)) {
            return "Number"; }
        else { return "String";
            //return word string if the user enters a string
            //return the work number if the user enters a number 


            //if <> == string()
            //Console.WriteLine("The textIn is a String)

            //else
            //if <> == number; 
            //Colsole.WriteLine("The textIn is a Number")

        }
    }
}
