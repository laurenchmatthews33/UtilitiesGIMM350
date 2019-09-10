using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities : MonoBehaviour
{

    public static string AvTextLength(string str)
    {
        string[] strings = str.Split (' ');
        int total = 0; 

        foreach (string word in strings)
        {
            total += word.Length; 
        }
        return "" + total / strings.Length;

}
}
    // Start is called before the first frame update
    //public static string ProcessText(string textIn)
    //{

    // double.TryParse(textIn, out phrase);

    //if (double.TryParse(textIn, out phrase)) {
    // return "Number"; }
    // else { return "String";
    //return word string if the user enters a string
    //return the work number if the user enters a number 


    //if <> == string()
    //Console.WriteLine("The textIn is a String)

    //else
    //if <> == number; 
    //Colsole.WriteLine("The textIn is a Number")


    

