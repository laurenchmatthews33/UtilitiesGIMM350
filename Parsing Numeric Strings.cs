using System;

public class ParsingNumericStrings

{
	public Class1()
	{
        //all numeric types have two static parsing methods - Parse and Tryparse, that you can use to convert the 
        //string representation of a nimber or numeric type. These methods enable you to parse strings that were 
        //produced by using the format strings. 

        //parse and tryparse can successfuly convert strings that contain integral and fractional decimal digits, 
        //group separators, and a decimal separator to floating point values. The parse method throws an exception 
        //if the operation fails, whereas the TryParse method returns false. 

        //Typically the string representations of numeric values differ by culture. Elements of numeric strings
        //such as currency symbols, group (or thousands) separators and decimal separators all vary by culture. Parsing
        //methods either implicitly or explicitly use a format provider that recognizes the culture specific variations
        //if no format provider is specified, the format provider associated woth the current thread culture is used. 

        //a format privider is represented by an iFormatProvider implementation consisting of a single member
        //interface, the GetFormat method, whose single perameter is a Type obhect that represents the type to be formatted. 
        //This method provides formatting information .Net supports the following two IFormatProvider implements for 
        //parsing numeric strings: 
        //a CultureInfo object whose CultureInfo.GetFormat method returns a NumberFormatInfo
        //object that provides cultural specific formatting information. 
        //a NumberFormatInfo object whose NumberFormatInfo.GetFormat method returns itsself. 

        //The following example tries to convert each string in an array to a doulbe value. It first tries to parse the 
        //string by using a format provider that refelcts the conventions of the English culture. If this operation 
        //throws a FormatException, it tries to parse the string by using format provider that reflects the conventions
        //of the French culture. 

       /* public static void Main()
        {
            string[] values = { "1,304.16", "$1,456.78", "1,094", "152",
                          "123,45 €", "1 304,16", "Ae9f" }; //array of strings.
            double number; 
            CultureInfo culture = null;

            foreach (string value in values)
            {
                try
                {
                    culture = CultureInfo.CreateSpecificCulture("en-US");
                    number = Double.Parse(value, culture);
                    Console.WriteLine("{0}: {1} --> {2}", culture.Name, value, number);
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0}: Unable to parse '{1}'.",
                                      culture.Name, value);
                    culture = CultureInfo.CreateSpecificCulture("fr-FR");
                    try
                    {
                        number = Double.Parse(value, culture);
                        Console.WriteLine("{0}: {1} --> {2}", culture.Name, value, number);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("{0}: Unable to parse '{1}'.",
                                          culture.Name, value);
                    }
                }
                Console.WriteLine();
            }
        }
    }*/
    // The example displays the following output:
    //    en-US: 1,304.16 --> 1304.16
    //    
    //    en-US: Unable to parse '$1,456.78'.
    //    fr-FR: Unable to parse '$1,456.78'.
    //    
    //    en-US: 1,094 --> 1094
    //    
    //    en-US: 152 --> 152
    //    
    //    en-US: Unable to parse '123,45 €'.
    //    fr-FR: Unable to parse '123,45 €'.
    //    
    //    en-US: Unable to parse '1 304,16'.
    //    fr-FR: 1 304,16 --> 1304.16
    //    
    //    en-US: Unable to parse 'Ae9f'.
    //    fr-FR: Unable to parse 'Ae9f'.


    //how to parse strings - the string split method - creates an array of substrings by splitting the input string based
    //on one of more deliminators - the easiest way to separate a string on word boundaries. It is also used to split
    //strings on other specific characters or strings. the following code splits a common phrase into an array of strings
    //for each word. 

    string phrase = "The quick brown fox jumps over the lazy dog";//giving a phrase 
    string[] words = phrase.Split(' '); 

    foreach (var word in words)
        {
        System.Console.WriteLine($"<{word}>"); 
        }
        //Every instance of a separator character produces a value in the returned array. Consecutive separator
        //characters produce an empty string as a value in the returned array - see below - 

        string phrase = "The quick brown   fox   jumps over the lazy dog";
        string[] words = phrase.Split(' '); 

        foreach (var word in words)
            
            {
            System.Console.WriteLine($"<{word}>"); 
            }//This makes it easier for formats like comma separated values representing tabular data. Consecutive 
             //commas represent a blank column. 

        //optional StringSplitOptions.RemoveEmptyEntries - parameter can be passed to exclude empty strings in the 
        //returned array. A LINQ can be used to process a more complicated collections. 

        //string spli can use multiple separator characters. See the following. 

        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

        string text = "one\ttwo three:four,five six seven";
        System.Console.WriteLine($"Original text: '{text}'");

        string[] words = text.Split(delimiterChars);
        System.Console.WriteLine($"{words.Length} words in text:");

        foreach (var word in words)
        {
            System.Console.WriteLine($"<{word}>");
        }
        //the above uses spaces, periods, colons, tabs 
        //consecutive instances of any separator produce the empty string in the outuput array.  

        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

        string text = "one\ttwo :,five six seven";
        System.Console.WriteLine($"Original text: '{text}'");

        string[] words = text.Split(delimiterChars);
        System.Console.WriteLine($"{words.Length} words in text:");

        foreach (var word in words)
        {
            System.Console.WriteLine($"<{word}>");
        }

        //String.Split can take an array of strings (character sequences that act as separators for parsing the
        //target string, instead of single characters)

        string[] separatingStrings = { "<<", "..." };

        string text = "one<<two......three<four";
        System.Console.WriteLine($"Original text: '{text}'");

        string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
        System.Console.WriteLine($"{words.Length} substrings in text:");

        foreach (var word in words)
        {
            System.Console.WriteLine(word);
        }


        //parsing and NumberStyles Values. 
        public class Example
    {
        public static void Main()
        {
            string value = "1,304";
            int number;
            IFormatProvider provider = CultureInfo.CreateSpecificCulture("en-US");
            if (Int32.TryParse(value, out number))
                Console.WriteLine("{0} --> {1}", value, number);
            else
                Console.WriteLine("Unable to convert '{0}'", value);

            if (Int32.TryParse(value, NumberStyles.Integer | NumberStyles.AllowThousands,
                              provider, out number))
                Console.WriteLine("{0} --> {1}", value, number);
            else
                Console.WriteLine("Unable to convert '{0}'", value);
        }
    }
// The example displays the following output:
//       Unable to convert '1,304'
//       1,304 --> 1304